using MARShop.Application.Middleware;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.PermissionRepository;
using MARShop.Infastructure.Repositories.RolePermissionRepository;
using MARShop.Infastructure.Repositories.RoleRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.RoleHandler.Commands.CreateRole
{
    public class CreateRoleCommand : IRequest<DResult>
    {
        public string Name { get; set; }
        public List<string> PermissionKeys { get; set; }
    }

    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, DResult>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IPermissionRepository _permissionRepository;
        private readonly IRolePermissionRepository _rolePermissionRepository;

        public CreateRoleCommandHandler(IRoleRepository roleRepository, IPermissionRepository permissionRepository, IRolePermissionRepository rolePermissionRepository)
        {
            _roleRepository = roleRepository;
            _permissionRepository = permissionRepository;
            _rolePermissionRepository = rolePermissionRepository;
        }

        public async Task<DResult> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var roleRequest = new Role()
            {
                Title = request.Name
            };
            var newRole = await _roleRepository.DAddAsync(roleRequest);
            foreach (var permissionKey in request.PermissionKeys)
            {
                var permissionEntity = await _permissionRepository.DFistOrDefaultAsync(a => a.Key.Equals(permissionKey));
                if(permissionEntity == null)
                {
                    throw new AppException();
                }
                var rolePermissionRequest = new RolePermission()
                {
                    PermissionId = permissionEntity.Id,
                    RoleId = newRole.Id
                };
                await _rolePermissionRepository.DAddAsync(rolePermissionRequest);
            }
            return DResult.Success();
        }
    }
}
