using MARShop.Core.Common;
using System.Collections.Generic;

namespace MARShop.Core.Entities
{
    public class Role : AuditableEntity
    {
        public string Title { get; set; }
        public IList<AccountRole> AccountRoles { get; set; }
        public IList<RolePermission> RolePermissions { get; set; }
    }
}