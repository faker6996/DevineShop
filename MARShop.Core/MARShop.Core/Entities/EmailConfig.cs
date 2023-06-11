using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class EmailConfig: AuditableEntity
    {
        public string Email { get; set; }
        public string AppPassword { get; set; }
    }
}
