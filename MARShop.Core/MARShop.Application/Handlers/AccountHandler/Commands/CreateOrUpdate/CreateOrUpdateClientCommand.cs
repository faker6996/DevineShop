using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.AccountHandler.Commands.CreateOrUpdate
{
    public class CreateOrUpdateClientCommand : IRequest<Respond>
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string LinkWeb { get; set; }
        public bool IsSendEmailWhenHaveNewPost { get; set; }
        public bool IsSendEmailWhenHaveNewComment { get; set; }
        public string BlogPostId { get; set; }
    }
    public class CreateOrUpdateClientCommandHandler : IRequestHandler<CreateOrUpdateClientCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateOrUpdateClientCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond> Handle(CreateOrUpdateClientCommand request, CancellationToken cancellationToken)
        {
            // check blogPostExist
            if (!await IsBlogPostsExist(request.BlogPostId))
            {
                throw new AppException("Bài viết không tồn tại");
            }

            var existAccount = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == request.Email);
            if (existAccount == null)
            {
                await CreateNewClientAsync(request);
            }
            else
            {
                await UpdateClientAsync(request, existAccount);
            }

            return Respond.Success();
        }
        private async Task CreateNewClientAsync(CreateOrUpdateClientCommand clientInfo)
        {
            var accountEntity = await _unitOfWork.Accounts.DAddAsync(AccountMapper.Mapper.Map<Account>(clientInfo));
            await _unitOfWork.AccountBlogPosts.DAddAsync(new AccountBlogPost()
            {
                AccountId = accountEntity.Id,
                BlogPostId = clientInfo.BlogPostId,
                IsLiked = false,
                IsSendEmailWhenHaveNewComment = clientInfo.IsSendEmailWhenHaveNewComment
            });
            await _unitOfWork.SaveAsync();
        }
        private async Task UpdateClientAsync(CreateOrUpdateClientCommand clientInfo, Account existAccount)
        {
            // change exist account info
            existAccount.Name = clientInfo.Name;
            existAccount.LinkWeb = clientInfo.LinkWeb ?? existAccount.LinkWeb;
            existAccount.IsSendEmailWhenHaveNewPost = clientInfo.IsSendEmailWhenHaveNewPost;

            await _unitOfWork.Accounts.DUpdateAsync(existAccount);

            // check account and postblog exist together
            var accountBlogPostExist = await _unitOfWork.AccountBlogPosts
                                 .DFistOrDefaultAsync(a => a.AccountId.Equals(existAccount.Id) && a.BlogPostId.Equals(clientInfo.BlogPostId));

            if (accountBlogPostExist == null)
            {
                await _unitOfWork.AccountBlogPosts.DAddAsync(new AccountBlogPost()
                {
                    AccountId = existAccount.Id,
                    BlogPostId = clientInfo.BlogPostId,
                    IsLiked = false,
                    IsSendEmailWhenHaveNewComment = clientInfo.IsSendEmailWhenHaveNewComment
                });
            }
            else
            {
                accountBlogPostExist.IsSendEmailWhenHaveNewComment = clientInfo.IsSendEmailWhenHaveNewComment;
                await _unitOfWork.AccountBlogPosts.DUpdateAsync(accountBlogPostExist);
            }

            await _unitOfWork.SaveAsync();
        }
        private async Task<bool> IsBlogPostsExist(string blogPostId)
        {
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == blogPostId);
            return blogPost != null;
        }
    }
}
