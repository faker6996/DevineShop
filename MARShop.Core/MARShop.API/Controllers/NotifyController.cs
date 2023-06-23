using MARShop.Application.Handlers.NotifyHandler.Commands.Update;
using MARShop.Application.Handlers.NotifyHandler.Queries.Paging;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [Route("api/[controller]")]

    public class NotifyController : ControllerBase
    {
        private readonly IMediator _mediator;
        public NotifyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Paging")]
        public async Task<ActionResult> Paging([FromBody] PagingNofityQuery query) => Ok(await _mediator.Send(query));

        [HttpPatch("Read-All")]
        public async Task<ActionResult> Read()
        {
            var command = new ReadAllNotifyCommand();
            return Ok(await _mediator.Send(command));
        }
    }
}
