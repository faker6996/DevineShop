using MARShop.Application.AccountHandler.Commands.CreateOrUpdate;
using MARShop.Application.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("client")]
        public async Task<ActionResult<Respond>> CreateOrUpdateClient([FromBody] CreateOrUpdateClientCommand command) => Ok(await _mediator.Send(command));
    }
}
