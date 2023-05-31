using MARShop.Application.HistoryHandler.Commands.CreateHistory;
using MARShop.Application.HistoryHandler.Queries.GetHistoryPaging;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [Route("api/history")]
    [ApiController]

    public class HistoryController: ControllerBase
    {
        private readonly IMediator _mediator;

        public HistoryController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Create([FromForm] CreateHistoryCommand command)
        {
            var result = await _mediator.Send(command);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> GetPaging([FromQuery] GetHistoryPagingQuery queries)
        {
            var result = await _mediator.Send(queries);
            return Ok(result);
        }
    }
}
