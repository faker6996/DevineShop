using MARShop.Infastructure.Repositories.PermissionRepository;
using MARShop.Infastructure.Repositories.RolePermissionRepository;
using MARShop.Infastructure.Repositories.RoleRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.RoleHandler.Queries.GetRole
{
    public class GetRoleQuery : IRequest<GetRoleResponse>
    {
        public int Id { get; set; }
        public GetRoleQuery(int Id)
        {
            this.Id = Id;
        }
    }
    public class GetRoleResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class GetRoleQueryHandler : IRequestHandler<GetRoleQuery, GetRoleResponse>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IPermissionRepository _permissionRepository;
        private readonly IRolePermissionRepository _rolePermissionRepository;

        public GetRoleQueryHandler(IRoleRepository roleRepository, IPermissionRepository permissionRepository, IRolePermissionRepository rolePermissionRepository)
        {
            _roleRepository = roleRepository;
            _permissionRepository = permissionRepository;
            _rolePermissionRepository = rolePermissionRepository;
        }

        public async Task<GetRoleResponse> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            var role = await _roleRepository.DGetByIdAsync(request.Id);
            if(role == null)
            {
                return null;
            }
            return new GetRoleResponse()
            {
                Id = role.Id,
                Title=role.Title
            };
        }
    }
}
