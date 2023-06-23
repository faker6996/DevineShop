using MARShop.Core.Common;
using System.Collections.Generic;

namespace MARShop.Core.Entities
{
    public class Account : AuditableEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string  LinkWeb { get; set; }
        public bool IsSendEmailWhenHaveNewPost { get; set; }
        public IList<AccountBlogPost> AccountBlogPosts { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
