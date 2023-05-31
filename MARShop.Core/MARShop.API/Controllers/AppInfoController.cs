using MARShop.Application.AppInfoHandler.Commands.UpdateInfo;
using MARShop.Application.AppInfoHandler.Queries.GetAppInfo;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    //[Authorize]
    [Route("api/appInfo")]
    [ApiController]
    public class AppInfoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppInfoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Update([FromBody] UpdateAppInfoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<bool>> Get()
        {
            var query = new GetAppInfoQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
