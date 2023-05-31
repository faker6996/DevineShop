using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.AccountRoleRepository;
using MARShop.Infastructure.Repositories.RoleRepository;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.RoleHandler.Queries.GetRoleByUserId
{
    public class GetRoleByUserIdQuery : IRequest<IList<GetRoleByUserIdResponse>>
    {
        public int Id { get; set; }
    }
    public class GetRoleByUserIdResponse
    {
        public string RoleTitle { get; set; }
        public int RoleId { get; set; }
        public bool Assigned { get; set; }

        public GetRoleByUserIdResponse(string roleTitle, int roleId, bool assigned)
        {
            RoleTitle = roleTitle;
            RoleId = roleId;
            Assigned = assigned;
        }
    }
    public class GetRoleByUserIdHandler : IRequestHandler<GetRoleByUserIdQuery, IList<GetRoleByUserIdResponse>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAccountRoleRepository _accountRoleRepository;
        private readonly IRoleRepository _roleRepository;

        public GetRoleByUserIdHandler(IHttpContextAccessor httpContextAccessor, IAccountRoleRepository accountRoleRepository, IRoleRepository roleRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _accountRoleRepository = accountRoleRepository;
            _roleRepository = roleRepository;
        }

        public async Task<IList<GetRoleByUserIdResponse>> Handle(GetRoleByUserIdQuery request, CancellationToken cancellationToken)
        {
            var roles = await _roleRepository.DGetAllAsync();
            //var accountId = _httpContextAccessor.HttpContext.User.FindFirst(DClaimType.Id).Value;

            var result = new List<GetRoleByUserIdResponse>();

            foreach (var role in roles)
            {
                var accountRole = await _accountRoleRepository.DFistOrDefaultAsync(a => a.RoleId.Equals(role.Id) && a.AccountId.Equals(request.Id));
                var assigned = accountRole != null;
                var roleByUser = new GetRoleByUserIdResponse(role.Title, role.Id, assigned);
                result.Add(roleByUser);
            }
            return result;
        }
    }
}
