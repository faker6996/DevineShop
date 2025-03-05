using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class Cart : AuditableEntity
    {
        public int? Quantity { get; set; }
        public int? AccountId { get; set; }
        public int? ProductId { get; set; }
    }
}
