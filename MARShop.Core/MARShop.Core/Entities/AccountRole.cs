using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class AccountRole: AuditableEntity
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
