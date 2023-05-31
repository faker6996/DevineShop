using MARShop.Core.Common;
using System.Collections.Generic;

namespace MARShop.Core.Entities
{
    public class Account : AuditableEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public IList<AccountRole> AccountRoles { get; set; }
    }
}
