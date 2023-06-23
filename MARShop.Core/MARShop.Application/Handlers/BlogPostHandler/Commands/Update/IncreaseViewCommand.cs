using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.BlogPostHandler.Commands.Update
{
    public class IncreaseViewCommand : IRequest<Respond>
    {
        public string BlogPostId { get; set; }
    }

    public class IncreaseViewCommandHandler : IRequestHandler<IncreaseViewCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IncreaseViewCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(IncreaseViewCommand request, CancellationToken cancellationToken)
        {
            // Check blog post exist
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.BlogPostId);
            if (blogPost == null)
            {
                throw new AppException("Bài viết không tồn tại");
            }

            // increate view
            blogPost.Views += 1;
            await _unitOfWork.BlogPosts.DUpdateAsync(blogPost);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
