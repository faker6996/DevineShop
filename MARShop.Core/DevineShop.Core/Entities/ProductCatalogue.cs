using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class ProductCatalogue : AuditableEntity
    {
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal? OriginalPrice { get; set; }
        public decimal? SalePrice { get; set; }
    }
}
