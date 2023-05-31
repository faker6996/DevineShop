using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.PermissionRepository;
using MARShop.Infastructure.Repositories.RolePermissionRepository;
using MARShop.Infastructure.Repositories.RoleRepository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.RoleHandler.Queries.GetRolePaging
{
    public class GetRolePagingQuery : IRequest<DResult<DPaging<GetRolePagingResponse>>>
    {
        public int Skip { get; set; }
        public int PageSize { get; set; }
    }
    public class GetRolePagingResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IList<PermissionResponse> Permissions { get; set; }
    }
    public class PermissionResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Key { get; set; }
    }
    public class GetRolePagingQueryHandler : IRequestHandler<GetRolePagingQuery, DResult<DPaging<GetRolePagingResponse>>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IPermissionRepository _permissionRepository;
        private readonly IRolePermissionRepository _rolePermissionRepository;

        public GetRolePagingQueryHandler(IRoleRepository roleRepository, IPermissionRepository permissionRepository, IRolePermissionRepository rolePermissionRepository)
        {
            _roleRepository = roleRepository;
            _permissionRepository = permissionRepository;
            _rolePermissionRepository = rolePermissionRepository;
        }

        public async Task<DResult<DPaging<GetRolePagingResponse>>> Handle(GetRolePagingQuery request, CancellationToken cancellationToken)
        {
            var rolesEntity = await _roleRepository.DGetPagingAsync(request.Skip, request.PageSize);
            var total = await _roleRepository.DGetTotalAsync();
            var rolesResult = new List<GetRolePagingResponse>();

            foreach (var role in rolesEntity)
            {
                var rolePermissions = await _rolePermissionRepository.DGetAsync(a => a.RoleId.Equals(role.Id));
                var roleResult = new GetRolePagingResponse()
                {
                    Id = role.Id,
                    Title = role.Title,
                    Permissions = new List<PermissionResponse>()
                };
                foreach (var rolePermission in rolePermissions)
                {
                    var permissionEntity = await _permissionRepository.DFistOrDefaultAsync(a => a.Id.Equals(rolePermission.PermissionId));
                    if (permissionEntity != null)
                    {
                        var permissionResult = new PermissionResponse()
                        {
                            Id = permissionEntity.Id,
                            Title = permissionEntity.Title,
                            Key = permissionEntity.Key,
                        };
                        roleResult.Permissions.Add(permissionResult);
                    }
                }
                rolesResult.Add(roleResult);
            }
            var result = new DPaging<GetRolePagingResponse>()
            {
                Items = rolesResult,
                TotalItems = total
            };
            return DResult<DPaging<GetRolePagingResponse>>.Success(result);
        }
    }
}
