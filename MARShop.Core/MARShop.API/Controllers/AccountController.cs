using MARShop.Application.Handlers.AccountHandler.Commands.ChangePassword;
using MARShop.Application.Handlers.AccountHandler.Commands.Create;
using MARShop.Application.Handlers.AccountHandler.Commands.Delete;
using MARShop.Application.Handlers.AccountHandler.Queries.Auth;
using MARShop.Application.Handlers.AccountHandler.Queries.Paging;
using MARShop.Application.Handlers.BlogPostHandler.Queries.Paging;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpPost("Auth/Validate")]
        public async Task<ActionResult> AuthValidate() => Ok();
        [HttpPost("Auth")]
        public async Task<ActionResult> Auth([FromBody] AuthQuery query) => Ok(await _mediator.Send(query));
        
        [HttpPost("Auth-Admin")]
        public async Task<ActionResult> AuthAdmin([FromBody] AdminAuthQuery query) => Ok(await _mediator.Send(query));

        [HttpPatch("ChangePass")]
        public async Task<ActionResult> ChangePass([FromBody] ChangePasswordAdminCommand command) => Ok(await _mediator.Send(command));

        [HttpPatch("ResetPassword")]
        public async Task<ActionResult> ResetPassword([FromBody] ResetPasswordCommand command) => Ok(await _mediator.Send(command));

        [HttpPost("Create/Client")]
        public async Task<ActionResult> CreateClient([FromBody] CreateAccountClientCommand command) => Ok(await _mediator.Send(command));
        [HttpPost("Paging")]
        public async Task<ActionResult> Paging([FromBody] PagingAccountQuery query) => Ok(await _mediator.Send(query));

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] DeleteAccountCommand command)=> Ok(await _mediator.Send(command));
    }
}
