using MARShop.Application.Middleware;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.PermissionRepository;
using MARShop.Infastructure.Repositories.RolePermissionRepository;
using MARShop.Infastructure.Repositories.RoleRepository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.RoleHandler.Commands.UpdateRole
{
    public class UpdateRoleCommand : IRequest<DResult>
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public IList<string> Permissionkeys { get; set; }
    }
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, DResult>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IRolePermissionRepository _rolePermissionRepository;
        private readonly IPermissionRepository _permissionRepository;

        public UpdateRoleCommandHandler(IRoleRepository roleRepository, IRolePermissionRepository rolePermissionRepository, IPermissionRepository permissionRepository)
        {
            _roleRepository = roleRepository;
            _rolePermissionRepository = rolePermissionRepository;
            _permissionRepository = permissionRepository;
        }

        public async Task<DResult> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var roleRequest = new Role()
            {
                Id = request.RoleId,
                Title = request.Name
            };
            await _roleRepository.DUpdateAsync(roleRequest);
            await _rolePermissionRepository.DDeleteAsync(a => a.RoleId == request.RoleId);

            foreach (var permissionKey in request.Permissionkeys)
            {
                var permissionEntity = await _permissionRepository.DFistOrDefaultAsync(a => a.Key.Equals(permissionKey));
                if (permissionEntity == null)
                {
                    throw new AppException();
                }
                var rolePermissionRequest = new RolePermission()
                {
                    PermissionId = permissionEntity.Id,
                    RoleId = request.RoleId
                };
                await _rolePermissionRepository.DAddAsync(rolePermissionRequest);
            }
            return DResult.Success();
        }
    }
}
