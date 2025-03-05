using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class ProductComment : AuditableEntity
    {
        public int? ProductId { get; set; }
        public int? CommentId { get; set; }
    }
}
