using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.HistoryRepository;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.HistoryHandler.Queries.GetHistoryPaging
{
    public class GetHistoryPagingQuery : IRequest<DResult<List<GetHistoryPagingResponse>>>
    {
        public string PhoneNumber { get; set; }
    }
    public class GetHistoryPagingResponse
    {
        public int Id { get; set; }
        public int MediaId { get; set; }
        public string MediaName { get; set; }
        public string ProductLink { get; set; }
    }

    public class GetHistoryPagingQueryHandler : IRequestHandler<GetHistoryPagingQuery, DResult<List<GetHistoryPagingResponse>>>
    {
        private readonly IHistoryRepository _historyRepository;
        private readonly IMediaRepository _mediaRepository;
        public GetHistoryPagingQueryHandler(IHistoryRepository historyRepository, IMediaRepository mediaRepository)
        {
            _historyRepository = historyRepository;
            _mediaRepository = mediaRepository;
        }
        public async Task<DResult<List<GetHistoryPagingResponse>>> Handle(GetHistoryPagingQuery request, CancellationToken cancellationToken)
        {
            const int SKIP = 0;
            const int PAGE_SIZE = 20;
            var entities = await _historyRepository.GetPagingHistoriesAsync(SKIP, PAGE_SIZE);
            var items = new List<GetHistoryPagingResponse>();

            foreach (var entity in entities)
            {
                var mediaEntity = await _mediaRepository.DGetByIdAsync(entity.MediaId);
                var mediaMetaData = JsonSerializer.Deserialize<MediaMetaData>(mediaEntity.MediaFile);

                var item = new GetHistoryPagingResponse()
                {
                    Id = entity.Id,
                    MediaId = entity.MediaId,
                    MediaName = mediaEntity.Name,
                    ProductLink = mediaMetaData.MediaProductInfos[0].ProductLink
                };

                items.Add(item);
            }

            return DResult<List<GetHistoryPagingResponse>>.Success(items);
        }
    }
}
