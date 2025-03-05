using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class ProductImage : AuditableEntity
    {
        public int? ImageId { get; set; }
        public int? ProductId { get; set; }
        public int? Type { get; set; }
    }
}
