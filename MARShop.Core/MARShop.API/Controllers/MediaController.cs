using MARShop.Application.MediaHandler.Commands.CreateMedia;
using MARShop.Application.MediaHandler.Commands.DeleteMedia;
using MARShop.Application.MediaHandler.Commands.UpdateMedia;
using MARShop.Application.MediaHandler.Queries.GetMedia;
using MARShop.Application.MediaHandler.Queries.GetMediaPaging;
using MARShop.Application.MediaHandler.Queries.GetTargetStatus;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    //[Authorize]
    [Route("api/media")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;

        public MediaController(IMediator mediator, IConfiguration configuration)
        {
            _mediator = mediator;
            _configuration = configuration;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Create([FromBody] CreateMediaCommand command)
        {
            command.AccessKey = _configuration.GetSection("VuforiaSetting").GetSection("AccessKey").Value;
            command.SecretKey = _configuration.GetSection("VuforiaSetting").GetSection("SecretKey").Value;

            var result = await _mediator.Send(command);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Update([FromBody] UpdateMediaCommand command)
        {
            command.AccessKey = _configuration.GetSection("VuforiaSetting").GetSection("AccessKey").Value;
            command.SecretKey = _configuration.GetSection("VuforiaSetting").GetSection("SecretKey").Value;

            var result = await _mediator.Send(command);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Get(int id)
        {
            var query = new GetMediaQuery() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("target/status/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> GetTargetStatus(int id)
        {
            var query = new GetTargetStatusQuery()
            {
                Id = id,
                AccessKey = _configuration.GetSection("VuforiaSetting").GetSection("AccessKey").Value,
                SecretKey = _configuration.GetSection("VuforiaSetting").GetSection("SecretKey").Value
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> GetPaging([FromQuery] GetMediaPagingQuery queries)
        {
            var result = await _mediator.Send(queries);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteMediaCommand(id);
            command.AccessKey = _configuration.GetSection("VuforiaSetting").GetSection("AccessKey").Value;
            command.SecretKey = _configuration.GetSection("VuforiaSetting").GetSection("SecretKey").Value;
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}

