using DevineShop.Core.Common;

namespace DevineShop.Core.Entities
{
    public class EmailConfig: AuditableEntity
    {
        public string Email { get; set; }
        public string AppPassword { get; set; }
    }
}
