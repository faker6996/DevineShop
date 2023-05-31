using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class History : AuditableEntity
    {
        public string PhoneNumber { get; set; }
        public int MediaId { get; set; }
    }
}
