using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.RolePermissionRepository;
using MARShop.Infastructure.Repositories.RoleRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.RoleHandler.Commands.DeleteRole
{
    public class DeleteRoleCommand : IRequest<DResult>
    {
        public int Id { get; set; }

        public DeleteRoleCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, DResult>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IRolePermissionRepository _rolePermissionRepository;

        public DeleteRoleCommandHandler(IRoleRepository roleRepository, IRolePermissionRepository rolePermissionRepository)
        {
            _roleRepository = roleRepository;
            _rolePermissionRepository = rolePermissionRepository;
        }

        public async Task<DResult> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            await _roleRepository.DeleteByIdAsync(request.Id);
            await _rolePermissionRepository.DDeleteAsync(a => a.RoleId == request.Id);
            return DResult.Success();
        }
    }
}
