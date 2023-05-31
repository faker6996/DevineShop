using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.AccountRepository;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AccountHandler.Commands.UpdateAccount
{
    public class UpdateAccountCommand : IRequest<DResult>
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class UpdateAccountCommandHandler : IRequestHandler<UpdateAccountCommand, DResult>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UpdateAccountCommandHandler(IAccountRepository accountRepository, IHttpContextAccessor httpContextAccessor)
        {
            _accountRepository = accountRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<DResult> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
        {
            var currentUserIdLogged = Int32.Parse(_httpContextAccessor.HttpContext.User.FindFirst(DClaimType.Id)?.Value);
            var user = await _accountRepository.DFistOrDefaultAsync(a => a.Id == currentUserIdLogged && a.Password == request.OldPassword);
            if (user == null)
            {
                return DResult.Failure("Mật khẩu cũ không chính xác");
            }
            await _accountRepository.ChangePassword(currentUserIdLogged, request.OldPassword, request.NewPassword);
            return DResult.Success();
        }
    }
}
