using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class Banner : AuditableEntity
    {
        public int? ImageId { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
    }
}
