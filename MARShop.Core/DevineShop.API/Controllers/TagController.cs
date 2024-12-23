using DevineShop.Application.Common;
using DevineShop.Application.Handlers.TagHandler.Commands.Create;
using DevineShop.Application.Handlers.TagHandler.Commands.Delete;
using DevineShop.Application.Handlers.TagHandler.Commands.Update;
using DevineShop.Application.Handlers.TagHandler.Queries.All;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevineShop.API.Controllers
{
    [Route("api/[controller]")]
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Respond>> Create([FromBody] CreateTagCommand command) => Ok(await _mediator.Send(command));
        [HttpGet("all")]
        public async Task<ActionResult<Respond<IList<TagRespond>>>> GetAll() => Ok(await _mediator.Send(new GetAllTagQuery()));
        [HttpPut]
        public async Task<ActionResult<Respond>> Update([FromBody] UpdateTagCommand command) => Ok(await _mediator.Send(command));
        [HttpDelete]
        public async Task<ActionResult<Respond>> Delete([FromBody] DeleteTagCommand command) => Ok(await _mediator.Send(command));
    }
}
