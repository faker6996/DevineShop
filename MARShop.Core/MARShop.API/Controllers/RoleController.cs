using MARShop.Application.RoleHandler.Commands.AssignRole;
using MARShop.Application.RoleHandler.Commands.CreateRole;
using MARShop.Application.RoleHandler.Commands.DeleteRole;
using MARShop.Application.RoleHandler.Commands.UpdateRole;
using MARShop.Application.RoleHandler.Queries.GetRole;
using MARShop.Application.RoleHandler.Queries.GetRoleByUserId;
using MARShop.Application.RoleHandler.Queries.GetRolePaging;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [Route("api/role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region get
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Get(int id)
        {
            var query = new GetRoleQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> GetPaging([FromQuery] GetRolePagingQuery queries)
        {
            var result = await _mediator.Send(queries);
            return Ok(result);
        }
        [HttpGet("account/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> GetByAccount()
        {
            var query = new GetRoleByUserIdQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        #endregion

        #region post
        [HttpPost("assign")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Assign([FromBody] AssignRoleCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Create([FromBody] CreateRoleCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        #endregion

        #region delete
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var query = new DeleteRoleCommand(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        #endregion

        #region put
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Update([FromBody] UpdateRoleCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        #endregion
    }
}
