using DevineShop.Core.Common;
using System;

namespace DevineShop.Core.Entities
{
    public class AccountBlogPost: AuditableEntity
    {
        public int? AccountId { get; set; }
        public int? BlogPostId { get; set; }
        public bool IsLiked { get; set; }
        public bool IsSendEmailWhenHaveNewComment { get; set; }     
        public BlogPost BlogPost { get; set;}
        public Account Account { get; set; }
    }
}
