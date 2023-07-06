using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.BlogPostHandler.Commands.Update
{
    public class UpdateBlogPostCommand : IRequest<Respond>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }

        public IList<string> TagIds { get; set; }
    }

    public class UpdateBlogPostCommandHandler : IRequestHandler<UpdateBlogPostCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateBlogPostCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(UpdateBlogPostCommand request, CancellationToken cancellationToken)
        {
            // Check blog post exist
            var blogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.Id);
            if (blogPost == null)
            {
                throw new AppException("Bài viết không tồn tại");
            }

            BlogPostMapper.Mapper.Map(request, blogPost);

            await _unitOfWork.BlogPosts.DUpdateAsync(blogPost);

            // Update blog post tags
            await UpdateBlogPostTags(blogPost.Id, request.TagIds);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }


        private async Task UpdateBlogPostTags(string blogPostId, IList<string> tagIds)
        {
            // Remove old blog post tags
            var blogPostTags = _unitOfWork.BlogPostTags.DGet(a => a.BlogPostId == blogPostId);

            foreach (var blogPostTag in blogPostTags)
            {
                await _unitOfWork.BlogPostTags.DDeleteAsync(blogPostTag);
            }

            // Add new blog post tags
            foreach (var tagId in tagIds)
            {
                var tag =await _unitOfWork.Tags.DFistOrDefaultAsync(a => a.Id == tagId);
                if (tag == null) throw new AppException($"Nhãn dán không tồn tại");
                var blogPostTag = new BlogPostTag()
                {
                    BlogPostId = blogPostId,
                    TagId = tagId
                };

                await _unitOfWork.BlogPostTags.DAddAsync(blogPostTag);
            }
        }
    }
}
