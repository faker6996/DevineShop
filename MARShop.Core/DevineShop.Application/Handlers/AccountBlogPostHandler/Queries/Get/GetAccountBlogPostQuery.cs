using DevineShop.Application.Common;
using DevineShop.Application.Mapper;
using DevineShop.Core.Entities;
using DevineShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevineShop.Application.Handlers.AccountBlogPostHandler.Queries.Get
{
    public class GetAccountBlogPostQuery : IRequest<Respond<AccountBlogPostRespond>>
    {
        public int AccountId { get; set; }
        public int BlogPostId { get; set; }
    }

    public class AccountBlogPostRespond
    {
        public int AccountId { get; set; }
        public int BlogPostId { get; set; }
        public bool IsLiked { get; set; }
        public bool IsSendEmailWhenHaveNewComment { get; set; }
    }

    public class GetAccountBlogPostQueryHandler : IRequestHandler<GetAccountBlogPostQuery, Respond<AccountBlogPostRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAccountBlogPostQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<AccountBlogPostRespond>> Handle(GetAccountBlogPostQuery request, CancellationToken cancellationToken)
        {
            var accountBlogPost = await _unitOfWork.AccountBlogPosts.DFistOrDefaultAsync(a => a.AccountId == request.AccountId && a.BlogPostId == request.BlogPostId);

            if (accountBlogPost == null)
            {
                var newAccountBlogPost = new AccountBlogPost()
                {
                    AccountId = request.AccountId,
                    BlogPostId = request.BlogPostId,
                    IsLiked = false,
                    IsSendEmailWhenHaveNewComment = false
                };

                await _unitOfWork.AccountBlogPosts.DAddAsync(newAccountBlogPost);
                await _unitOfWork.SaveAsync();

                var respond = AccountBlogPostMapper.Mapper.Map<AccountBlogPostRespond>(newAccountBlogPost);
                return Respond<AccountBlogPostRespond>.Success(respond);
            }
            else
            {
                var respond = AccountBlogPostMapper.Mapper.Map<AccountBlogPostRespond>(accountBlogPost);
                return Respond<AccountBlogPostRespond>.Success(respond);
            }

        }
    }
}
