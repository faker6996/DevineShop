using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.ShopRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.ShopHandler.Commands.CreateShop
{
    public class CreateShopCommand : IRequest<DResult>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string LatLong { get; set; }
        public string Description { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
    }

    public class CreateShopCommandHandler : IRequestHandler<CreateShopCommand, DResult>
    {
        private readonly IShopRepository _shopRepository;

        public CreateShopCommandHandler(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<DResult> Handle(CreateShopCommand request, CancellationToken cancellationToken)
        {
            var entity = ShopMapper.Mapper.Map<Shop>(request);
            await _shopRepository.DAddAsync(entity);
            return DResult.Success();
        }
    }
}
