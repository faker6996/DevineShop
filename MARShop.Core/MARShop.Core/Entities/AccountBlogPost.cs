using MARShop.Core.Common;
using System;

namespace MARShop.Core.Entities
{
    public class AccountBlogPost: AuditableEntity
    {
        public string AccountId { get; set; }
        public string BlogPostId { get; set; }
        public bool IsLiked { get; set; }
        public bool IsSendEmailWhenHaveNewComment { get; set; }     
        public BlogPost BlogPost { get; set;}
        public Account Account { get; set; }
    }
}
