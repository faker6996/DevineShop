using MARShop.Application.Common;
using MARShop.Application.Handlers.NotifyHandler.Commands.Create;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Core.Enum;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using Microsoft.Extensions.Configuration;
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
        private readonly IMediator _mediator;


        public CreateCommentCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public async Task<Respond> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            // check account exist
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Id == request.AccountId);
            if (account == null) throw new AppException("Tài khoản không tồn tại");

            // check blog post exist
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.BlogPostId);
            if (blogPost == null) throw new AppException("Bài viết không tồn tại");

            var comment = CommentMapper.Mapper.Map<Comment>(request);
            await _unitOfWork.Comments.DAddAsync(comment);

            await _unitOfWork.SaveAsync();

            var notifyCommand = new CreateNotifyCommand()
            {
                Type = nameof(NotifyType.BlogPost),
                Content = $"Bạn {account.Name} có Email là {account.Email} đã bình luận tại bài viết {blogPost.Title}",
                Link = $"{blogPost.Category}/{blogPost.Slug}",
                Title = "Thông báo bình luận",
                IsRead = false
            };

            await _mediator.Send(notifyCommand);

            return Respond.Success();
        }
    }
}
