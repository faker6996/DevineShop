using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AccountHandler.Commands.ResetPasswordAccount
{
    public class ResetPasswordAccountCommand: IRequest<DResult>
    {
        public string Password { get; set; }
        public int Id { get; set; }
    }

    public class ResetPasswordAccountCommandHandler : IRequestHandler<ResetPasswordAccountCommand, DResult>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResetPasswordAccountCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DResult> Handle(ResetPasswordAccountCommand request, CancellationToken cancellationToken)
        {
            var entity =await _unitOfWork.Accounts.DGetByIdAsync(request.Id);
            entity.Password = request.Password;

            await _unitOfWork.Accounts.DUpdateAsync(entity);
            await _unitOfWork.Save();
            return DResult.Success();
        }
    }
}
