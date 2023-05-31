using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class AppInfo: AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
