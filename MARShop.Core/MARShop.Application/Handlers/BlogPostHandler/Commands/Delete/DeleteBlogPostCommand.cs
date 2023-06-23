using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.BlogPostHandler.Commands.Delete
{
    public class DeleteBlogPostCommand : IRequest<Respond>
    {
        public string Id { get; set; }
    }

    public class DeleteBlogPostCommandHandler : IRequestHandler<DeleteBlogPostCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteBlogPostCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(DeleteBlogPostCommand request, CancellationToken cancellationToken)
        {
            var blogPost = await _unitOfWork.BlogPosts.DGetByIdAsync(request.Id);

            // check blog post exist
            if (blogPost == null)
            {
                throw new AppException("Bài viết không tồn tại");
            }

            // remove blog post
            await _unitOfWork.BlogPosts.DeleteByIdAsync(request.Id);

            // remove blog post tags
            var blogPostTags = _unitOfWork.BlogPostTags.DGet(a => a.BlogPostId == request.Id);
            foreach (var blogPostTag in blogPostTags)
            {
                await _unitOfWork.BlogPostTags.DDeleteAsync(blogPostTag);
            }

            // remove account blog posts
            var accountBlogPosts = _unitOfWork.AccountBlogPosts.DGet(a => a.BlogPostId == request.Id);
            foreach (var accountBlogPost in accountBlogPosts)
            {
                await _unitOfWork.AccountBlogPosts.DDeleteAsync(accountBlogPost);
            }

            // remove comment relative to blog posts
            var comments = _unitOfWork.Comments.DGet(a=>a.BlogPostId==request.Id);
            foreach (var comment in comments)
            {
                await _unitOfWork.Comments.DDeleteAsync(comment);
            }

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
