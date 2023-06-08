using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.BlogPostHandler.Commands.Update
{
    public class UpdateLikeBlogPostCommand : IRequest<Respond>
    {
        public string AccountId { get; set; }
        public string BlogPostId { get; set; }
        public bool IsLike { get; set; }
    }

    public class UpdateLikeBlogPostCommandHandler : IRequestHandler<UpdateLikeBlogPostCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateLikeBlogPostCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(UpdateLikeBlogPostCommand request, CancellationToken cancellationToken)
        {
            // check blogPost exist
            if (!await IsBlogPostsExist(request.BlogPostId))
            {
                throw new AppException("Blog post don't exist");
            }

            // check account exist
            if (!await IsAccountExist(request.AccountId))
            {
                throw new AppException("Account don't exist");
            }

            // update account blog post
            var accountBlogPost = await _unitOfWork.AccountBlogPosts.DFistOrDefaultAsync(a => a.AccountId == request.AccountId && a.BlogPostId == request.BlogPostId);
            accountBlogPost.IsLiked = request.IsLike;
            await _unitOfWork.AccountBlogPosts.DUpdateAsync(accountBlogPost);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
        private async Task<bool> IsBlogPostsExist(string blogPostId)
        {
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == blogPostId);
            return blogPost != null;
        }

        private async Task<bool> IsAccountExist(string accountId)
        {
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Id == accountId);
            return account != null;
        }
    }
}
