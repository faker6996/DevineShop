using MARShop.Application.Common;
using MARShop.Application.Enum;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.TagHandler.Commands.Create
{
    public class CreateTagCommand : IRequest<Respond>
    {
        public string Title { get; set; }
    }
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTagCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        } 
        public async Task<Respond> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            if (await IsExistTag(request.Title))
            {
                throw new AppException("Tag name is duplicate");
            }

            await _unitOfWork.Tags.DAddAsync(TagMapper.Mapper.Map<Tag>(request));
            await _unitOfWork.SaveAsync();
            return Respond.Success();
        }
        private async Task<bool> IsExistTag(string title)
        {
            var tag = await _unitOfWork.Tags.DFistOrDefaultAsync(a => a.Title == title);
            return tag != null;
        }
    }
}
