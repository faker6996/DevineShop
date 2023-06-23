using MARShop.Application.Common;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.NotifyHandler.Commands.Update
{
    public class ReadAllNotifyCommand : IRequest<Respond>
    {
    }
    public class ReadAllNotifyCommandHandler : IRequestHandler<ReadAllNotifyCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReadAllNotifyCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(ReadAllNotifyCommand request, CancellationToken cancellationToken)
        {
            var unreadNotifies = _unitOfWork.Notifies.DGet(a => a.IsRead == false);

            foreach (var notify in unreadNotifies)
            {
                notify.IsRead = true;
                await _unitOfWork.Notifies.DUpdateAsync(notify);
            }

            await _unitOfWork.SaveAsync();
            return Respond.Success();
        }
    }
}
