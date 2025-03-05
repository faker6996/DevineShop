using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class Category : AuditableEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
