using MARShop.Core.Common;
using System;

namespace MARShop.Core.Entities
{
    public class Comment:AuditableEntity
    {
        public string AccountId { get; set; }
        public string BlogPostId { get; set; }
        public string ParentId { get; set; }
        public string Content { get; set; } 
        public Account Account { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
