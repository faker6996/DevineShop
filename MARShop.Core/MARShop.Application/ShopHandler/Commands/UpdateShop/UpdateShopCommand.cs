using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.ShopRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.ShopHandler.Commands.UpdateShop
{
    public class UpdateShopCommand : IRequest<DResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string LatLong { get; set; }
        public string Description { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
    }

    public class UpdateShopCommandHandler : IRequestHandler<UpdateShopCommand, DResult>
    {
        private readonly IShopRepository _shopRepository;

        public UpdateShopCommandHandler(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<DResult> Handle(UpdateShopCommand request, CancellationToken cancellationToken)
        {
            var entity = ShopMapper.Mapper.Map<Shop>(request);
            await _shopRepository.DUpdateAsync(entity);
            return DResult.Success();
        }
    }
}
