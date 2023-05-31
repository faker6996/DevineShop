using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AccountHandler.Commands.DeleteAccount
{
    public class DeleteAccountCommand: IRequest<DResult>
    {
        public int Id { get; set; }

        public DeleteAccountCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand, DResult>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAccountCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DResult> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.Accounts.DeleteByIdAsync(request.Id);
            await _unitOfWork.Save();
            return DResult.Success();
        }
    }
}
