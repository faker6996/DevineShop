﻿using MARShop.Application.Common;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Create;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Delete;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Update;
using MARShop.Application.Handlers.BlogPostHandler.Queries.Get;
using MARShop.Application.Handlers.BlogPostHandler.Queries.Paging;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpPatch]
        public async Task<ActionResult<Respond>> Update([FromBody] UpdateBlogPostCommand command) => Ok(await _mediator.Send(command));
        [HttpPatch("Increase-View")]
        public async Task<ActionResult<Respond>> IncreateView([FromBody] IncreaseViewCommand command) => Ok(await _mediator.Send(command));
        [HttpPatch("Update-Like")]
        public async Task<ActionResult<Respond>> UpdateLike([FromBody] UpdateLikeBlogPostCommand command) => Ok(await _mediator.Send(command));

        [HttpDelete, Route("{id}")]
        public async Task<ActionResult<Respond>> Delete(string id)
        {
            var deleteBlogPostCommand = new DeleteBlogPostCommand() { Id = id };
            return Ok(await _mediator.Send(deleteBlogPostCommand));
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var getBlogPostQuery = new GetBlogPostQuery() { Id = id };
            return Ok(await _mediator.Send(getBlogPostQuery));
        }

        [HttpPost("Paging")]
        public async Task<ActionResult> Paging([FromBody] PagingBlogPostQuery query) => Ok(await _mediator.Send(query));
    }
}