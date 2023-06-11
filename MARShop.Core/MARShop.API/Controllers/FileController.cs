using MARShop.Application.Enum;
using MARShop.Application.Handlers.FileHandler.Upload;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MARShop.API.Controllers
{
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CoverImage")]
        public async Task<ActionResult> UpCoverImage(IFormFile file)
        {
            var uploadCoverImage = new UploadFileCommand() { File = file, Type = nameof(UploadFileType.CoverImage) };
            return Ok(await _mediator.Send(uploadCoverImage));
        }

        [HttpPost("ContentImage")]
        public async Task<ActionResult> UpContentImage(IFormFile file)
        {
            var uploadCoverImage = new UploadFileCommand() { File = file, Type = nameof(UploadFileType.ContentImage) };
            return Ok(await _mediator.Send(uploadCoverImage));
        }
    }
}
