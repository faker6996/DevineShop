using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class ProductCategory : AuditableEntity
    {
        public int? CategoryId { get; set; }
        public int? ProductId { get; set; }
    }
}
