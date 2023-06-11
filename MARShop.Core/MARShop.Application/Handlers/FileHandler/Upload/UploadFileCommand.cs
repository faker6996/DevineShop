using MARShop.Application.Common;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MARShop.Application.Handlers.FileHandler.Upload
{
    public class UploadFileCommand : IRequest<Respond<UploadFileRespond>>
    {
        public string Type { get; set; }
        public IFormFile File { get; set; }

    }
    public class UploadFileRespond
    {
        public string Src { get; set; }
    }

    public class UploadFileCommandHandler : IRequestHandler<UploadFileCommand, Respond<UploadFileRespond>>
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UploadFileCommandHandler(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<Respond<UploadFileRespond>> Handle(UploadFileCommand request, CancellationToken cancellationToken)
        {
            var relativePathFile = Path.Combine(request.Type, $"{Guid.NewGuid().ToString()}-{request.File.FileName}");
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, relativePathFile);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                request.File.CopyTo(stream);
            }
            return Respond<UploadFileRespond>.Success(new UploadFileRespond() { Src = relativePathFile });
        }
    }
}
