using System;

namespace MARShop.Core.Common
{
    public class AuditableEntity
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDelete { get; set; }
    }
}
