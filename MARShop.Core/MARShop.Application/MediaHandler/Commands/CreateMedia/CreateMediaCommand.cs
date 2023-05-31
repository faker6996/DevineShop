using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Application.Share;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

namespace MARShop.Application.MediaHandler.Commands.CreateMedia
{
    public class FileCreate
    {
        public string MediaContent { get; set; }
        public string MediaName { get; set; }
        public string ProductLink { get; set; }
    }
    public class CreateMediaCommand : IRequest<DResult>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FileCreate ImageIdentity { get; set; }
        public FileCreate[] MediaFile { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public float ImageIdentityWidth { get; set; }
    }

    public class CreateMediaCommandHandler : IRequestHandler<CreateMediaCommand, DResult>
    {
        private readonly IMediaRepository _mediaRepository;
        private readonly IWebHostEnvironment _enviroment;

        public CreateMediaCommandHandler(IMediaRepository mediaRepository, IWebHostEnvironment enviroment)
        {
            _mediaRepository = mediaRepository;
            _enviroment = enviroment;
        }

        public async Task<DResult> Handle(CreateMediaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var FolderId = Guid.NewGuid().ToString();
                var UPLOAD_IMAGE_ID_FOLDER = $"\\upload\\imageId\\{FolderId}\\";
                var UPLOAD_IMAGE_ID_FOLDER_Fix = $"upload/imageId/{FolderId}/";
                var UPLOAD_MEDIA_FOLDER = $"\\upload\\media\\{FolderId}\\";
                var UPLOAD_MEDIA_FOLDER_Fix = $"upload/media/{FolderId}/";
                if (request.ImageIdentity != null && request.MediaFile != null)
                {
                    DFile.WriteData(request.ImageIdentity.MediaName, request.ImageIdentity.MediaContent, $"{_enviroment.WebRootPath}{UPLOAD_IMAGE_ID_FOLDER}");

                    var mediaMetaData = new MediaMetaData();
                    mediaMetaData.MediaName = request.Name;
                    for (int i = 0; i < request.MediaFile.Length; i++)
                    {
                        DFile.WriteData(request.MediaFile[i].MediaName, request.MediaFile[i].MediaContent, $"{_enviroment.WebRootPath}{UPLOAD_MEDIA_FOLDER}{i}\\");

                        mediaMetaData.MediaProductInfos.Add(new MediaProductInfo()
                        {
                            MediaLink = $"{UPLOAD_MEDIA_FOLDER}{i}\\{request.MediaFile[i].MediaName}",
                            ProductLink = request.MediaFile[i].ProductLink
                        });
                    }

                    var mediaMetaDataJson = JsonSerializer.Serialize<MediaMetaData>(mediaMetaData);
                    var imageTarget = DConvertor.Bas64Of32bitsTo24bits(request.ImageIdentity.MediaContent.Substring(request.ImageIdentity.MediaContent.LastIndexOf(',') + 1));

                    var vWSGet = new VWSCreate()
                    {
                        AccessKey = request.AccessKey,
                        SecretKey = request.SecretKey,
                        Width = request.ImageIdentityWidth,
                        Active_flag = 1,
                        Application_metadata = DConvertor.StringToBase64(mediaMetaDataJson),
                        Image = imageTarget,
                        Name = DateTime.Now.ToUniversalTime().ToString(),
                    };

                    var imageIdetityInVuforia = DVuforia.AddTarget(vWSGet);

                    var entity = MediaMapper.Mapper.Map<Media>(request);
                    entity.ImageIdentityIdInVuforia = imageIdetityInVuforia;
                    entity.MediaFile = mediaMetaDataJson;
                    entity.ImageIdentity = UPLOAD_IMAGE_ID_FOLDER_Fix + request.ImageIdentity.MediaName;

                    await _mediaRepository.DAddAsync(entity);

                    return DResult.Success();
                }
                else
                {
                    return DResult.Failure();
                }
            }
            catch (Exception ex)
            {
                return DResult.Failure();
            }
            return DResult.Success();
        }
    }
}
