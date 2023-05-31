using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.ShopRepository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.ShopHandler.Queries.GetShopPaging
{
    public class GetShopPagingQuery : IRequest<DResult<DPaging<GetShopPagingResponse>>>
    {
        public int Skip { get; set; }
        public int PageSize { get; set; }
        public string KeyWord { get; set; }
        public string StartLatLong { get; set; }
    }

    public class GetShopPagingResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string LatLong { get; set; }
        public string Description { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
    }

    public class GetShopPagingQueryHandler : IRequestHandler<GetShopPagingQuery, DResult<DPaging<GetShopPagingResponse>>>
    {
        private readonly IShopRepository _shopRepository;

        public GetShopPagingQueryHandler(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }
        public async Task<DResult<DPaging<GetShopPagingResponse>>> Handle(GetShopPagingQuery request, CancellationToken cancellationToken)
        {
            var entities = request.StartLatLong == null ?
                 await _shopRepository.GetPagingShopsAsync(request.Skip, request.PageSize,request.KeyWord) : 
                 await _shopRepository.GetPagingShopsAsync(request.Skip, request.PageSize,request.KeyWord, MARShop.Infastructure.Share.DConvertor.LatLongToArray(request.StartLatLong));
            var items = ShopMapper.Mapper.Map<List<GetShopPagingResponse>>(entities);


            var total = await _shopRepository.DGetTotalShopWithKeyWordConditionAsync(request.KeyWord);

            var result = new DPaging<GetShopPagingResponse>()
            {
                Items = items,

                TotalItems = total,
            };
            return DResult<DPaging<GetShopPagingResponse>>.Success(result);
        }
    }
}
