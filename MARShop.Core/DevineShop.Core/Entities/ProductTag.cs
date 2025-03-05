using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class ProductTag : AuditableEntity
    {
        public int? TagId { get; set; }
        public int? ProductId { get; set; }
    }
}
