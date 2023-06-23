using MARShop.Application.Common;
using MARShop.Application.Hubs;
using MARShop.Application.Mapper;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.NotifyHandler.Commands.Create
{
    public class CreateNotifyCommand : IRequest<Respond>
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public bool IsRead { get; set; }
    }

    public class CreateNotifyCommandHandler : IRequestHandler<CreateNotifyCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHubContext<NotificationHub> _notificationHub;


        public CreateNotifyCommandHandler(IUnitOfWork unitOfWork, IHubContext<NotificationHub> notificationHub)
        {
            _unitOfWork = unitOfWork;
            _notificationHub = notificationHub;
        }
        public async Task<Respond> Handle(CreateNotifyCommand request, CancellationToken cancellationToken)
        {
            var notify = NotifyMapper.Mapper.Map<Notify>(request);

            await _unitOfWork.Notifies.DAddAsync(notify);

            await _unitOfWork.SaveAsync();

            await _notificationHub.Clients.All.SendAsync("ReceiveMsg", request.Content);

            return Respond.Success();
        }
    }
}
