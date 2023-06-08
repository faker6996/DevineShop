using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.CommentHandler.Commands.Create
{
    public class CreateCommentCommand : IRequest<Respond>
    {
        public string AccountId { get; set; }
        public string BlogPostId { get; set; }
        public string ParentId { get; set; }
        public string Content { get; set; }
    }

    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateCommentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            // check account exist
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Id == request.AccountId);
            if (account == null) throw new AppException("Account dont exist");

            // check blog post exist
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.BlogPostId);
            if (blogPost == null) throw new AppException("Account dont exist");

            var comment = CommentMapper.Mapper.Map<Comment>(request);
            await _unitOfWork.Comments.DAddAsync(comment);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
