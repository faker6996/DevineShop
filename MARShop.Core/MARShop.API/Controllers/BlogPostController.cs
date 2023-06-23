using MARShop.Application.Common;
using MARShop.Application.Handlers.AccountBlogPostHandler.Queries.Get;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Create;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Delete;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Update;
using MARShop.Application.Handlers.BlogPostHandler.Queries.Get;
using MARShop.Application.Handlers.BlogPostHandler.Queries.Paging;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MARShop.API.Controllers
{
    [Route("api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogPostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Respond>> Create([FromBody] CreateBlogPostCommand command) => Ok(await _mediator.Send(command));
        [HttpPost("Paging")]
        public async Task<ActionResult> Paging([FromBody] PagingBlogPostQuery query) => Ok(await _mediator.Send(query));
         [HttpPost("Relevant")]
        public async Task<ActionResult> PagingRelavant([FromBody] PagingBlogPostRelevantQuery query) => Ok(await _mediator.Send(query));

        [HttpPatch]
        public async Task<ActionResult<Respond>> Update([FromBody] UpdateBlogPostCommand command) => Ok(await _mediator.Send(command));
        [HttpPatch("Increase-View")]
        public async Task<ActionResult<Respond>> IncreateView([FromBody] IncreaseViewCommand command) => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpPatch("Update-Like")]
        public async Task<ActionResult<Respond>> UpdateLike([FromBody] UpdateLikeBlogPostCommand command) => Ok(await _mediator.Send(command));

        [HttpDelete, Route("{id}")]
        public async Task<ActionResult<Respond>> Delete(string id)
        {
            var deleteBlogPostCommand = new DeleteBlogPostCommand() { Id = id };
            return Ok(await _mediator.Send(deleteBlogPostCommand));
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] string id)
        {
            var getBlogPostQuery = new GetBlogPostQuery() { Id = id };
            return Ok(await _mediator.Send(getBlogPostQuery));
        }

        [HttpGet, Route("{slug}")]
        public async Task<ActionResult> GetBySlug(string slug)
        {
            var getBlogPostBySlugQuery = new GetBlogPostBySlugQuery() { Slug = slug };
            return Ok(await _mediator.Send(getBlogPostBySlugQuery));
        }
        [HttpGet("Account-Blog-Post")]
        public async Task<ActionResult> GetAccountBlogPost(string accountId, string blogpostId)
        {
            var query = new GetAccountBlogPostQuery() { AccountId = accountId, BlogPostId = blogpostId };
            return Ok(await _mediator.Send(query));
        }
    }
}