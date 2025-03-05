﻿using System;

namespace DevineShop.Core.Common
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool IsDelete { get; set; }
    }
}
