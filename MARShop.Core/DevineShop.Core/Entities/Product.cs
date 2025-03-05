using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int? ProductParentId { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }

    }
}
