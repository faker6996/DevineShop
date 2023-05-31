using MARShop.Application.ShopHandler.Commands.CreateShop;
using MARShop.Application.ShopHandler.Commands.DeleteShop;
using MARShop.Application.ShopHandler.Commands.UpdateShop;
using MARShop.Application.ShopHandler.Queries.GetShop;
using MARShop.Application.ShopHandler.Queries.GetShopPaging;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShopController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Create([FromBody] CreateShopCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Update([FromBody] UpdateShopCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Get(int id)
        {
            var query = new GetShopQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Get([FromQuery] GetShopPagingQuery queries)
        {
            var result = await _mediator.Send(queries);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var query = new DeleteShopCommand(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
