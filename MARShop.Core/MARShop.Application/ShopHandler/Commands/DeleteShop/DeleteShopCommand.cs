using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.ShopRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.ShopHandler.Commands.DeleteShop
{
    public class DeleteShopCommand: IRequest<DResult>
    {
        public int Id { get; set; }

        public DeleteShopCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteShopCommandHandler : IRequestHandler<DeleteShopCommand, DResult>
    {
        private readonly IShopRepository _shopRepository;

        public DeleteShopCommandHandler(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<DResult> Handle(DeleteShopCommand request, CancellationToken cancellationToken)
        {
            await _shopRepository.DeleteByIdAsync(request.Id);
            return DResult.Success();
        }
    }
}
