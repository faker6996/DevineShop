using MARShop.Application.Common;
using MARShop.Application.Enum;
using MARShop.Core.Common;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.BlogPostHandler.Queries.Paging
{
    public class PagingBlogPostQuery : IRequest<Respond<Paging<BlogPostRespond>>>
    {
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public Short ShortBy { get; set; } // values are Created, LastModified, Like, View
        public Filter Filter { get; set; } // values are Category, 
        public string KeyWord { get; set; }
    }
    public class Filter
    {
        public IList<string> CategoryIds { get; set; } // 3 
        public IList<string> TagIds { get; set; } // n 
    }
    public class Short
    {
        public string Title { get; set; }
        public bool IsIncrease { get; set; }
    }

    public class BlogPostRespond
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
        public IList<TagRespond> Tags { get; set; }
    }
    public class TagRespond
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

 
    public class PagingBlogPostQueryHandler : IRequestHandler<PagingBlogPostQuery, Respond<Paging<BlogPostRespond>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public PagingBlogPostQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<Paging<BlogPostRespond>>> Handle(PagingBlogPostQuery request, CancellationToken cancellationToken)
        {
            var blogPosts = _unitOfWork.BlogPosts.DGet(a => a.Title.Search(request.KeyWord));
            blogPosts = await Filter(blogPosts, request.Filter);
            blogPosts = DoShort(blogPosts, request.ShortBy);

            var totalRecord = blogPosts.Count();
            blogPosts = blogPosts.Skip(request.PerPage * (request.CurrentPage - 1)).Take(request.PerPage);

            var blogPostResponds = new List<BlogPostRespond>();
            foreach (var blogPost in blogPosts)
            {
                var likes = _unitOfWork.AccountBlogPosts.DGet(a => a.BlogPostId == blogPost.Id && a.IsLiked == true).Count();
                var tags = GetTagsByBlogPost(blogPost.Id).ToList();

                var blogPostRespond = new BlogPostRespond()
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

            var paging = new Paging<BlogPostRespond>()
            {
                Total = totalRecord,
                PerPage = request.PerPage,
                CurrentPage = request.CurrentPage,
                Items = blogPostResponds
            };

            return Respond<Paging<BlogPostRespond>>.Success(paging);
        }

        private async Task<IQueryable<BlogPost>> Filter(IQueryable<BlogPost> blogPosts, Filter filter)
        {
            // Filter Categories
            if (filter.CategoryIds.Count > 0)
            {
                blogPosts = blogPosts.Where(a => filter.CategoryIds.Contains(a.Category));
            }

            if (filter.TagIds.Count > 0)
            {
                // Get blog posts id have need tags
                var blogPostIdsHasNeedTag = new List<string>();
                foreach (var tagId in filter.TagIds)
                {
                    var blogPostIdsHasCurrentTag = _unitOfWork.BlogPostTags.DGet(a => a.TagId == tagId).Select(a => a.BlogPostId);
                    blogPostIdsHasNeedTag.AddRange(blogPostIdsHasCurrentTag);
                }
                // Filter Blog post
                blogPosts = blogPosts.Where(a => blogPostIdsHasNeedTag.Contains(a.Id));
            }
            return blogPosts;
        }

        private IQueryable<BlogPost> DoShort(IQueryable<BlogPost> blogPosts, Short shortBy)
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

        private IQueryable<TagRespond> GetTagsByBlogPost(string blogPostId)
        {
            return from blogPostTag in _unitOfWork.BlogPostTags.DGetAll()
                   join tag in _unitOfWork.Tags.DGetAll()
                   on blogPostTag.TagId equals tag.Id
                   where blogPostTag.BlogPostId == blogPostId
                   select new TagRespond()
                   {
                       Id = tag.Id,
                       Title = tag.Title
                   };
        }
    }

}
