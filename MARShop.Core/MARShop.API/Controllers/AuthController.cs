using MARShop.Application.AuthHandler.Commands.TokenCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public Task<TokenCommandResponse> Token([FromBody] TokenCommand command) => _mediator.Send(command);
    }
}
