using MARShop.Core.Common;
using System;
using System.Collections.Generic;

namespace MARShop.Core.Entities
{
    public class Permission : AuditableEntity
    {
        public string Title { get; set; }
        public string Key { get; set; }
        public int ParentId { get; set; }
        public IList<RolePermission> RolePermissions { get; set; }
    }
}
