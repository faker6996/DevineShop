using MARShop.Application.Common;
using MARShop.Application.Handlers.NotifyHandler.Commands.Create;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Core.Enum;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
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
        private readonly IMediator _mediator;

        public UpdateLikeBlogPostCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public async Task<Respond> Handle(UpdateLikeBlogPostCommand request, CancellationToken cancellationToken)
        {
            // check blogPost exist
            if (!await IsBlogPostsExist(request.BlogPostId))
            {
                throw new AppException("Bài viết không tồn tại");
            }

            // check account exist
            if (!await IsAccountExist(request.AccountId))
            {
                throw new AppException("Tài khoản không tồn tại");
            }

            var accountBlogPost = await _unitOfWork.AccountBlogPosts.DFistOrDefaultAsync(a => a.AccountId == request.AccountId && a.BlogPostId == request.BlogPostId);

            // create account blog post
            if (accountBlogPost == null)
            {
                await CreateAccountBlogPost(request);
            }
            // update account blog post
            else
            {
                AccountBlogPostMapper.Mapper.Map(request, accountBlogPost);
                accountBlogPost.IsLiked = request.IsLike;
                await _unitOfWork.AccountBlogPosts.DUpdateAsync(accountBlogPost);
            }

            await _unitOfWork.SaveAsync();

            if (request.IsLike)
            {
                var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Id == request.AccountId);
                var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.BlogPostId);
                var notifyCommand = new CreateNotifyCommand()
                {
                    Type = nameof(NotifyType.BlogPost),
                    Content = $"Bạn {account.Name} có Email là {account.Email} đã thích bài viết {blogPost.Title}",
                    Link = $"{blogPost.Category}/{blogPost.Slug}",
                    Title = "Thông báo yêu thích",
                    IsRead = false
                };

                await _mediator.Send(notifyCommand);
            }

            return Respond.Success();
        }
        private async Task CreateAccountBlogPost(UpdateLikeBlogPostCommand request)
        {
            var accountBlogPost = AccountBlogPostMapper.Mapper.Map<AccountBlogPost>(request);
            await _unitOfWork.AccountBlogPosts.DAddAsync(accountBlogPost);
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
