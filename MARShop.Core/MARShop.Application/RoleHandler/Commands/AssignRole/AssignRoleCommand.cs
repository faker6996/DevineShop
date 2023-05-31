using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.AccountRoleRepository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.RoleHandler.Commands.AssignRole
{
    public class AssignRoleCommand : IRequest<DResult>
    {
        public int AccountId { get; set; }
        public List<int> RolesId { get; set; }
    }

    public class AssingRoleCommandHandler : IRequestHandler<AssignRoleCommand, DResult>
    {
        private readonly IAccountRoleRepository _accountRoleRepository;

        public AssingRoleCommandHandler(IAccountRoleRepository accountRoleRepository)
        {
            _accountRoleRepository = accountRoleRepository;
        }

        public async Task<DResult> Handle(AssignRoleCommand request, CancellationToken cancellationToken)
        {
            foreach (var roleId in request.RolesId)
            {
                var accountRole = new AccountRole()
                {
                    RoleId = roleId,
                    AccountId = request.AccountId
                };
                await _accountRoleRepository.DAddAsync(accountRole);
            }
            return DResult.Success();
        }
    }
}
