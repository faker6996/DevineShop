using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class RolePermission : AuditableEntity
    {
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
