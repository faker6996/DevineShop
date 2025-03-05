using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class ProductPurchased : AuditableEntity
    {
        public int? AccountId { get; set; }
        public int? ProductCatalogueId { get; set; }
        public int? ProductId { get; set; }
    }
}
