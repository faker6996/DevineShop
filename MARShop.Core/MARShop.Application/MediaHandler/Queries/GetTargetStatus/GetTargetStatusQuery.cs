using MARShop.Application.MediaHandler.Queries.GetMedia;
using MARShop.Application.Models;
using MARShop.Application.Share;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.MediaHandler.Queries.GetTargetStatus
{
    public class GetTargetStatusQuery : IRequest<GetTargetStatusResponse>
    {
        public int Id { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
    }
    public class GetTargetStatusResponse
    {
        public string Status { get; set; }
    }
    public class GetTargetStatusHandler : IRequestHandler<GetTargetStatusQuery, GetTargetStatusResponse>
    {
        private readonly IMediaRepository _mediaRepository;

        public GetTargetStatusHandler(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public async Task<GetTargetStatusResponse> Handle(GetTargetStatusQuery request, CancellationToken cancellationToken)
        {
            var media = await _mediaRepository.DGetByIdAsync(request.Id);
            var vWSInfo = await GetVWSAsync(media, request.AccessKey, request.SecretKey);
            return new GetTargetStatusResponse() { Status = vWSInfo };
        }
        private async Task<string> GetVWSAsync(Media media, string accessKey, string secretKey)
        {
            var vWSGet = new VWSGet()
            {
                IdTarget = media.ImageIdentityIdInVuforia,
                AccessKey = accessKey,
                SecretKey = secretKey,
            };
            var result = DVuforia.GetTarget(vWSGet);
            return DConvertor.GetJsonValueByKey(result, "status");
        }
    }
}
