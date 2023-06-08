using MARShop.Core.Common;
using System;
using System.Collections.Generic;

namespace MARShop.Core.Entities
{
    public class Tag:AuditableEntity
    {
        public string Title { get; set; }
        public IList<BlogPostTag> BlogPostTags { get; set; }
    }
}
