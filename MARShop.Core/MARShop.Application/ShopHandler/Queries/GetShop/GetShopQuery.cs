using MARShop.Application.Mapper;
using MARShop.Infastructure.Repositories.ShopRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.ShopHandler.Queries.GetShop
{
    public class GetShopQuery : IRequest<GetShopResponse>
    {
        public int Id { get; set; }

        public GetShopQuery(int id)
        {
            Id = id;
        }
    }
    public class GetShopResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
    }

    public class GetShopQueryHandler : IRequestHandler<GetShopQuery, GetShopResponse>
    {
        private readonly IShopRepository _shopRepository;

        public GetShopQueryHandler(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<GetShopResponse> Handle(GetShopQuery request, CancellationToken cancellationToken)
        {
            var entity = await _shopRepository.DGetByIdAsync(request.Id);
            var result = ShopMapper.Mapper.Map<GetShopResponse>(entity);
            return result;

        }
    }
}
