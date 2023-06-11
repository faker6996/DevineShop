﻿using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.AccountHandler.Commands.ChangePassword
{
    public class ChangePasswordAdminCommand:IRequest<Respond>
    {
        public string UserName { get; set; }
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
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.UserName == request.UserName);

            // check username exist
            if (account == null) throw new AppException("Username not found");

            // check old password
            if (!BCrypt.Net.BCrypt.Verify(request.OldPassword, account.Password)) throw new AppException("Wrong old password");

            account.Password = BCrypt.Net.BCrypt.HashPassword(request.NewPassword);
            await _unitOfWork.Accounts.DUpdateAsync(account);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
