using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.TagHandler.Commands.Update
{
    public class UpdateTagCommand : IRequest<Respond>
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateTagCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            // check tag id exist
            var tag = await _unitOfWork.Tags.DFistOrDefaultAsync(a => a.Id == request.Id);
            if (tag == null)
            {
                throw new AppException("Nhãn không tồn tại");
            }

            // check name of tag duplicate
            if (await IsExistTag(request.Title))
            {
                throw new AppException("Tên nhãn đã tồn tại");
            }

            tag.Title = request.Title;
            await _unitOfWork.Tags.DUpdateAsync(tag);

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
