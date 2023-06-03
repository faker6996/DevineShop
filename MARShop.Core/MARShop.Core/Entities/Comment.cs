using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class Comment:AuditableEntity
    {
        public int AccountId { get; set; }
        public int BlogPostId { get; set; }
        public int ParentPostId { get; set; }
        public string Content { get; set; } 
        public Account Account { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
