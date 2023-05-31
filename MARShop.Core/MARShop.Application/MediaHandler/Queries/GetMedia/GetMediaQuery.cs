using MARShop.Application.Models;
using MARShop.Application.Share;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.MediaHandler.Queries.GetMedia
{
    public class GetMediaQuery : IRequest<GetMediaResponse>
    {
        public int Id { get; set; }
    }
    public class FileGet
    {
        public string MediaContent { get; set; }
        public string MediaName { get; set; }
        public string ProductLink { get; set; }
        public string MediaLink { get; set; }
        public FileGet(string mediaLink)
        {
            MediaLink = mediaLink;
            MediaContent = DConvertor.FileUrlToBase64(mediaLink);
            MediaName = Path.GetFileName(mediaLink);
        }
        public FileGet(string mediaLink, string productLink)
        {
            MediaLink = mediaLink;
            MediaContent = DConvertor.FileUrlToBase64(mediaLink);
            MediaName = Path.GetFileName(mediaLink);
            ProductLink = productLink;
        }
    }
    public class GetMediaResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FileGet ImageIdentity { get; set; }
        public List<FileGet> MediaFile { get; set; }
        public int ImageIdentityWidth { get; set; }
        public string ImageIdentityIdInVuforia { get; set; }
        public GetMediaResponse()
        {
            MediaFile= new List<FileGet>();
        }
    }

    public class GetMediaQueryHandler : IRequestHandler<GetMediaQuery, GetMediaResponse>
    {
        private readonly IMediaRepository _mediaRepository;
        private readonly IHostingEnvironment _hostingEnvironment;


        public GetMediaQueryHandler(IMediaRepository mediaRepository, IHostingEnvironment hostingEnvironment)
        {
            _mediaRepository = mediaRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<GetMediaResponse> Handle(GetMediaQuery request, CancellationToken cancellationToken)
        {
            var entity = await _mediaRepository.DGetByIdAsync(request.Id);
            var imageIdentityPath =Path.Combine(_hostingEnvironment.WebRootPath, entity.ImageIdentity);
            var imageIdentity = new FileGet(imageIdentityPath);
            var mediaMetaData = JsonSerializer.Deserialize<MediaMetaData>(entity.MediaFile);

            var getMediaResponse = new GetMediaResponse() {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                ImageIdentity = imageIdentity,
                ImageIdentityWidth = entity.ImageIdentityWidth,
                ImageIdentityIdInVuforia = entity.ImageIdentityIdInVuforia,
            };
            foreach (var item in mediaMetaData.MediaProductInfos)
            {
                var mediaPath = $"{_hostingEnvironment.WebRootPath}{item.MediaLink}";
                var mediaProductInfo = new FileGet(mediaPath, item.ProductLink);
                getMediaResponse.MediaFile.Add(mediaProductInfo);
            }
            return getMediaResponse;
        }
    }
}
