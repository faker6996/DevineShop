using MARShop.Application.Common;
using MARShop.Application.Handlers.AccountHandler.Commands.ChangePassword;
using MARShop.Application.Handlers.AccountHandler.Commands.Create;
using MARShop.Application.Handlers.AccountHandler.Commands.CreateOrUpdate;
using MARShop.Application.Handlers.AccountHandler.Queries.Auth;
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

        //[HttpPost("client")]
        //public async Task<ActionResult<Respond>> CreateOrUpdateClient([FromBody] CreateOrUpdateClientCommand command) => Ok(await _mediator.Send(command));

        [HttpPost("AuthAdmin")]
        public async Task<ActionResult> AuthAdmin([FromBody] AuthAdminQuery query) => Ok(await _mediator.Send(query));

        [HttpPost("ChangePassAdmin")]
        public async Task<ActionResult> ChangePassAdmin([FromBody] ChangePasswordAdminCommand command) => Ok(await _mediator.Send(command));

        [HttpPatch("ResetPassword")]
        public async Task<ActionResult> ResetPassword([FromBody] ResetPasswordCommand command) => Ok(await _mediator.Send(command));

        [HttpPost("Create/Client")]
        public async Task<ActionResult> CreateClient([FromBody] CreateAccountClientCommand command) => Ok(await _mediator.Send(command));
    }
}
