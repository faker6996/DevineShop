using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.MediaHandler.Queries.GetMediaPaging
{
    public class GetMediaPagingQuery : IRequest<DResult<DPaging<GetMediaPagingResponse>>>
    {
        public string keyWord { get; set; }
        public int Skip { get; set; }
        public int PageSize { get; set; }
    }
    public class GetMediaPagingResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageIdentity { get; set; }
        public string ImageIdentityIdInVuforia { get; set; }
        public float ImageIdentityWidth { get; set; }
        public MediaMetaData MediaInfo { get; set; }
    }

    public class GetMediaPagingQueryHandler : IRequestHandler<GetMediaPagingQuery, DResult<DPaging<GetMediaPagingResponse>>>
    {
        private readonly IMediaRepository _mediaRepository;

        public GetMediaPagingQueryHandler(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public async Task<DResult<DPaging<GetMediaPagingResponse>>> Handle(GetMediaPagingQuery request, CancellationToken cancellationToken)
        {
            var entities = await _mediaRepository.DGetPagingMediaAsync(request.Skip, request.PageSize, request.keyWord);
            var items = new List<GetMediaPagingResponse>();

            foreach (var entity in entities)
            {
                var mediaMetaData = JsonSerializer.Deserialize<MediaMetaData>(entity.MediaFile);

                var item = new GetMediaPagingResponse()
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Description = entity.Description,
                    ImageIdentity = entity.ImageIdentity,
                    ImageIdentityIdInVuforia = entity.ImageIdentityIdInVuforia,
                    ImageIdentityWidth = entity.ImageIdentityWidth,
                    MediaInfo = mediaMetaData
                };

                items.Add(item);
            }
            var total = await _mediaRepository.DGetTotalMediaWithKeyWordConditionAsync(request.keyWord);
            var result = new DPaging<GetMediaPagingResponse>()
            {
                Items = items,

                TotalItems = total,
            };
            return DResult<DPaging<GetMediaPagingResponse>>.Success(result);
        }
    }
}
