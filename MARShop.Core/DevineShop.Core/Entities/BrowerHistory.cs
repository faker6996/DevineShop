using DevineShop.Core.Common;
using System.Collections.Generic;

namespace DevineShop.Core.Entities
{
    public class BrowerHistory : AuditableEntity
    {
        public int? AccountId { get; set; }
        public int? ProductId { get; set; }
    }
}
