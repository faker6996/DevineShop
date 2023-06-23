using MARShop.Application.Handlers.ContactHandler.Commands.Update;
using MARShop.Application.Handlers.ContactHandler.Queries.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPatch()]
        public async Task<ActionResult> ChangePass([FromBody] UpdateContactCommand command) => Ok(await _mediator.Send(command));

        [HttpGet()]
        public async Task<ActionResult> Get()
        {
            var query = new GetContactQuery();
            return Ok(await _mediator.Send(query));
        }
    }
}
