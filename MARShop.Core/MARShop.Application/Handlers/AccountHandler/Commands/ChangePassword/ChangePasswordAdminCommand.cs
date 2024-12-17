using DevineShop.Application.Common;
using DevineShop.Application.Middleware;
using DevineShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevineShop.Application.Handlers.AccountHandler.Commands.ChangePassword
{
    public class ChangePasswordAdminCommand:IRequest<Respond>
    {
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class ChangePasswordAdminCommandHandler: IRequestHandler<ChangePasswordAdminCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChangePasswordAdminCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Respond> Handle(ChangePasswordAdminCommand request, CancellationToken cancellationToken)
        {
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == request.Email);

            // check Email exist
            if (account == null) throw new AppException("Email không tồn tại trong hệ thống");

            // check old password
            if (!BCrypt.Net.BCrypt.Verify(request.OldPassword, account.Password)) throw new AppException("Mật khẩu cũ không đúng");

            account.Password = BCrypt.Net.BCrypt.HashPassword(request.NewPassword);
            await _unitOfWork.Accounts.DUpdateAsync(account);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
