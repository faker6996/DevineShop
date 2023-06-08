using MARShop.Core.Common;
using System;

namespace MARShop.Core.Entities
{
    public class BlogPostTag:AuditableEntity
    {
        public string BlogPostId { get; set; }
        public string TagId { get; set; }
        public Tag Tag { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
