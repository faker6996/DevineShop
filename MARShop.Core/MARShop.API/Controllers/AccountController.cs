using MARShop.Application.AccountHandler.Commands.CreateAccount;
using MARShop.Application.AccountHandler.Commands.DeleteAccount;
using MARShop.Application.AccountHandler.Commands.ResetPasswordAccount;
using MARShop.Application.AccountHandler.Commands.UpdateAccount;
using MARShop.Application.AccountHandler.Queries.GetAccount;
using MARShop.Application.AccountHandler.Queries.GetAccountPaging;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    //todo: mở comment authorize ra để nó chạy
    //[Authorize]
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Create([FromBody] CreateAccountCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("changepass")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> ChangePassword([FromBody] UpdateAccountCommand command)
        {
            var result = await _mediator.Send(command);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Get(int id)
        {
            var query = new GetAccountQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        
        [HttpGet("current")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Get()
        {
            var query = new GetAccountLoginQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Get([FromQuery] GetAccountPagingQuery queries)
        {
            var result = await _mediator.Send(queries);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var query = new DeleteAccountCommand(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPut("resetpass")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> ChangePassword([FromBody] ResetPasswordAccountCommand command)
        {
            var result = await _mediator.Send(command);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }
    }
}
