using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Common;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Collections.Generic;
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
        public IList<string> TagIds { get; set; }
    }

    public class CreateBlogPostCommandHandler : IRequestHandler<CreateBlogPostCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateBlogPostCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(CreateBlogPostCommand request, CancellationToken cancellationToken)
        {
            // check title of blog code exist
            if (await IsTitleOfBlogPostExist(request.Title))
            {
                throw new AppException("Duplicate name of blog post");
            }

            // create blog post
            var blogPost = BlogPostMapper.Mapper.Map<BlogPost>(request);
            blogPost.Slug = request.Title.ToSlug();
            blogPost.Views = 0;
            await _unitOfWork.BlogPosts.DAddAsync(blogPost);

            // Create blog post tags
            await CreateBlogPostTags(blogPost.Id, request.TagIds);

            await _unitOfWork.SaveAsync();

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
                    throw new AppException($"Tag {tagId} dont exist");
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
    }
}
