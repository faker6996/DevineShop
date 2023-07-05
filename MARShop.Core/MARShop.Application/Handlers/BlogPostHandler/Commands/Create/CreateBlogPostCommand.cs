using MARShop.Application.Common;
using MARShop.Application.Handlers.EmailHandler.Queries;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Application.Share;
using MARShop.Core.Common;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.BlogPostHandler.Commands.Create
{
    public class CreateBlogPostCommand : IRequest<Respond>
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public IList<string> TagIds { get; set; }
    }

    public class CreateBlogPostCommandHandler : IRequestHandler<CreateBlogPostCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;


        public CreateBlogPostCommandHandler(IUnitOfWork unitOfWork, IMediator mediator, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
            _configuration = configuration;

        }

        public async Task<Respond> Handle(CreateBlogPostCommand request, CancellationToken cancellationToken)
        {
            // check title of blog code exist
            if (await IsTitleOfBlogPostExist(request.Title))
            {
                throw new AppException("Tên bài viết đã tồn tại");
            }

            // create blog post
            var blogPost = BlogPostMapper.Mapper.Map<BlogPost>(request);
            blogPost.Slug = request.Title.ToSlug();
            blogPost.Views = 0;
            await _unitOfWork.BlogPosts.DAddAsync(blogPost);

            // Create blog post tags
            await CreateBlogPostTags(blogPost.Id, request.TagIds);

            await _unitOfWork.SaveAsync();

            var emailSubcribers = _unitOfWork.Accounts.DGet(a => a.IsSendEmailWhenHaveNewPost == true).Select(a => a.Email).ToList();
            SendEmailToSubcriberAsync(emailSubcribers,blogPost);

            return Respond.Success();
        }

        private async Task CreateBlogPostTags(string blogPostId, IList<string> tagIds)
        {
            // Add new blog post tags
            foreach (var tagId in tagIds)
            {
                var tag = await _unitOfWork.Tags.DFistOrDefaultAsync(a => a.Id == tagId);
                if (tag == null)
                {
                    throw new AppException($"Nhãn dán không tồn tại");
                }
                var blogPostTag = new BlogPostTag()
                {
                    BlogPostId = blogPostId,
                    TagId = tagId
                };

                await _unitOfWork.BlogPostTags.DAddAsync(blogPostTag);
            }
        }

        private async Task<bool> IsTitleOfBlogPostExist(string title)
        {
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Title == title);
            return blogPost != null;
        }

        private async Task SendEmailToSubcriberAsync(List<string> emails,BlogPost blogPost)
        {
            foreach (var email in emails)
            {

                var emailQuery = new SendEmailQuery()
                {
                    ToMail = email,
                    Subject = "ĐÃ CÓ BÀI VIẾT MỚI",
                    Body = $"<body>\r\n<p>Xin chào,</p>\r\n<p>Tác giả đã có bài viêt mới, bạn có thể đón đọc tại đường dẫn: <a href=\"{_configuration["FrontEndEndPoint"]}{blogPost.Category.ToSubLink()}/{blogPost.Slug}\">{blogPost.Title}</a>.</p>\r\n</body>"
                };

                _mediator.Send(emailQuery);
            }
        }
    }
}
