using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.CommentHandler.Queries.Get
{
    public class GetCommentByBlogPostIdQuery : IRequest<Respond<CommentsRespond>>
    {
        public string Id { get; set; }
    }
    public class CommentsRespond
    {
        public IList<CommentRespond> Comments { get; set; }
        public int Total { get; set; }
    }
    public class CommentRespond : SubCommentRespond
    {
        public IList<SubCommentRespond> SubComments { get; set; } = new List<SubCommentRespond>();
    }
    public class SubCommentRespond
    {
        public string AccountId { get; set; }
        public string AccountUsername { get; set; }
        public string AccountName { get; set; }
        public string AccountEmail { get; set; }
        public string AccountLinkWeb { get; set; }
        public string CommentId { get; set; }
        public string CommentContent { get; set; }
        public DateTime Created { get; set; }

    }

    public class GetCommentByBlogPostIdQueryHandler : IRequestHandler<GetCommentByBlogPostIdQuery, Respond<CommentsRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetCommentByBlogPostIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond<CommentsRespond>> Handle(GetCommentByBlogPostIdQuery request, CancellationToken cancellationToken)
        {
            // check blog post exist
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.Id);
            if (blogPost == null) throw new AppException("Bài viết không tồn tại");

            var comments = _unitOfWork.Comments.DGet(a => a.BlogPostId == request.Id).ToList();

            var commentResponds = new List<CommentRespond>();
            var commentDontHaveParents = comments.Where(a => a.ParentId == null);

            foreach (var commentDontHaveParent in commentDontHaveParents)
            {
                var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Id == commentDontHaveParent.AccountId);
                commentResponds.Add(new CommentRespond()
                {
                    AccountId = account.Id,
                    AccountUsername = account.UserName,
                    AccountName = account.Name,
                    AccountEmail = account.Email,
                    AccountLinkWeb = account.LinkWeb,
                    CommentId = commentDontHaveParent.Id,
                    CommentContent = commentDontHaveParent.Content,
                    Created = commentDontHaveParent.Created
                });
            }

            var commentHaveParents = comments.Where(a => a.ParentId != null);

            foreach (var commentHaveParent in commentHaveParents)
            {
                var commentRespond = commentResponds.FirstOrDefault(a => a.CommentId == commentHaveParent.ParentId);
                var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Id == commentHaveParent.AccountId);

                commentRespond.SubComments.Add(new SubCommentRespond()
                {
                    AccountId = account.Id,
                    AccountUsername = account.UserName,
                    AccountName = account.Name,
                    AccountEmail = account.Email,
                    AccountLinkWeb = account.LinkWeb,
                    CommentId = commentHaveParent.Id,
                    CommentContent = commentHaveParent.Content,
                    Created = commentHaveParent.Created
                });
            }

            var commentsRespond = new CommentsRespond()
            {
                Comments = commentResponds,
                Total = comments.Count()
            };

            return Respond<CommentsRespond>.Success(commentsRespond);
        }
    }
}
