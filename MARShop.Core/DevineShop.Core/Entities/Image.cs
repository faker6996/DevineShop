using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class Image : AuditableEntity
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
