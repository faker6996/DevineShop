using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.TagHandler.Commands.Create
{
    public class CreateTagCommand : IRequest<Respond<CreateTagRespond>>
    {
        public string Title { get; set; }
    }

    public class CreateTagRespond
    {
        public string Title { get; set; }
        public string Id { get; set; }
    }
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, Respond<CreateTagRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTagCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<CreateTagRespond>> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            if (await IsExistTag(request.Title))
            {
                throw new AppException("Tên nhãn đã tồn tại");
            }

            var newTag = await _unitOfWork.Tags.DAddAsync(TagMapper.Mapper.Map<Tag>(request));
            var createTagRespond = new CreateTagRespond()
            {
                Id = newTag.Id,
                Title = newTag.Title,
            };

            await _unitOfWork.SaveAsync();
            return Respond<CreateTagRespond>.Success(createTagRespond);
        }
        private async Task<bool> IsExistTag(string title)
        {
            var tag = await _unitOfWork.Tags.DFistOrDefaultAsync(a => a.Title == title);
            return tag != null;
        }
    }
}
