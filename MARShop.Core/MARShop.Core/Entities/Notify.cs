using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class Notify : AuditableEntity
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public bool IsRead { get; set; }
    }
}
