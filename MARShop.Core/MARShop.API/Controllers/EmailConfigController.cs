using MARShop.Application.Handlers.EmailHandler.Commands.Update;
using MARShop.Application.Handlers.EmailHandler.Queries.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [Route("api/[controller]")]
    public class EmailConfigController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmailConfigController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPatch()]
        public async Task<ActionResult> Update([FromBody] UpdateEmailConfigCommand command) => Ok(await _mediator.Send(command));

        [HttpGet()]
        public async Task<ActionResult> Get()
        {
            var query = new EmailConfigQuery();

            return Ok(await _mediator.Send(query));
        }
    }
}
