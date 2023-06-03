using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class BlogPostTag:AuditableEntity
    {
        public int BlogPostId { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
