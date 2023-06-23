using MARShop.Application.Common;
using MediatR;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Threading;
using MARShop.Infastructure.UnitOfWork;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using System.Linq;
using MARShop.Application.Enum;

namespace MARShop.Application.Handlers.BlogPostHandler.Queries.Paging
{
    public class PagingBlogPostRelevantQuery : IRequest<Respond<Paging<BlogPostRelevantRespond>>>
    {
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public ShortRelevant ShortBy { get; set; } // values are Created, LastModified, Like, View
        public string BlogPostId { get; set; }
    }
    public class ShortRelevant
    {
        public string Title { get; set; }
        public bool IsIncrease { get; set; }
    }
    public class BlogPostRelevantRespond
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public DateTime Created { get; set; }
        public IList<TagRelevantRespond> Tags { get; set; }
    }

    public class TagRelevantRespond
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

    public class PagingBlogPostRelevantQueryHandler : IRequestHandler<PagingBlogPostRelevantQuery, Respond<Paging<BlogPostRelevantRespond>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public PagingBlogPostRelevantQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<Paging<BlogPostRelevantRespond>>> Handle(PagingBlogPostRelevantQuery request, CancellationToken cancellationToken)
        {
            var currentBlogPost = await _unitOfWork.BlogPosts.DFistOrDefaultAsync(a => a.Id == request.BlogPostId);
            if (currentBlogPost == null) throw new AppException("Bài viết không tồn tại !");

            var blogPosts = Filter(currentBlogPost);
            blogPosts = DoShort(blogPosts, request.ShortBy);

            var totalRecord = blogPosts.Count();
            blogPosts = blogPosts.Skip(request.PerPage * (request.CurrentPage - 1)).Take(request.PerPage);

            var blogPostResponds = new List<BlogPostRelevantRespond>();
            foreach (var blogPost in blogPosts)
            {
                var likes = _unitOfWork.AccountBlogPosts.DGet(a => a.BlogPostId == blogPost.Id && a.IsLiked == true).Count();
                var tags = GetTagsByBlogPost(blogPost.Id).ToList();

                var blogPostRespond = new BlogPostRelevantRespond()
                {
                    Id = blogPost.Id,
                    Title = blogPost.Title,
                    Image = blogPost.Image,
                    Slug = blogPost.Slug,
                    Views = blogPost.Views,
                    Likes = likes,
                    Category = blogPost.Category,
                    Summary = blogPost.Summary,
                    Created = blogPost.Created,
                    Tags = tags
                };

                blogPostResponds.Add(blogPostRespond);
            }

            var paging = new Paging<BlogPostRelevantRespond>()
            {
                Total = totalRecord,
                PerPage = request.PerPage,
                CurrentPage = request.CurrentPage,
                Items = blogPostResponds
            };

            return Respond<Paging<BlogPostRelevantRespond>>.Success(paging);
        }
        private IQueryable<BlogPost> Filter(BlogPost currentBlogPost)
        {
            var tagIdsFilter = _unitOfWork.BlogPostTags.DGet(a => a.BlogPostId == currentBlogPost.Id).Select(a => a.TagId).ToList();

            // Get blog posts id have need tags
            var blogPostIdsHasNeedTag = new List<string>();
            foreach (var tagId in tagIdsFilter)
            {
                var blogPostIdsHasCurrentTag = _unitOfWork.BlogPostTags.DGet(a => a.TagId == tagId).Select(a => a.BlogPostId).ToList();
                blogPostIdsHasNeedTag.AddRange(blogPostIdsHasCurrentTag);
            }


            return _unitOfWork.BlogPosts.DGet(a => blogPostIdsHasNeedTag.Contains(a.Id) && a.Id != currentBlogPost.Id);
        }
        private IQueryable<BlogPost> DoShort(IQueryable<BlogPost> blogPosts, ShortRelevant shortBy)
        {
            if (shortBy.IsIncrease)
            {
                // increase created
                if (shortBy.Title == nameof(ShortTitle.Created))
                {
                    blogPosts = blogPosts.OrderBy(a => a.Created);
                }

                // increase last modified
                if (shortBy.Title == nameof(ShortTitle.LastModified))
                {
                    blogPosts = blogPosts.OrderBy(a => a.LastModified);
                }

                // increase view
                if (shortBy.Title == nameof(ShortTitle.View))
                {
                    blogPosts = blogPosts.OrderBy(a => a.Views);
                }
            }

            else
            {
                // Descending created
                if (shortBy.Title == nameof(ShortTitle.Created))
                {
                    blogPosts = blogPosts.OrderByDescending(a => a.Created);
                }

                // Descending last modified
                if (shortBy.Title == nameof(ShortTitle.LastModified))
                {
                    blogPosts = blogPosts.OrderByDescending(a => a.LastModified);
                }

                // Descending view
                if (shortBy.Title == nameof(ShortTitle.View))
                {
                    blogPosts = blogPosts.OrderByDescending(a => a.Views);
                }
            }

            return blogPosts;
        }

        private IQueryable<TagRelevantRespond> GetTagsByBlogPost(string blogPostId)
        {
            return from blogPostTag in _unitOfWork.BlogPostTags.DGetAll()
                   join tag in _unitOfWork.Tags.DGetAll()
                   on blogPostTag.TagId equals tag.Id
                   where blogPostTag.BlogPostId == blogPostId
                   select new TagRelevantRespond()
                   {
                       Id = tag.Id,
                       Title = tag.Title
                   };
        }
    }
}
