using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class OTP : AuditableEntity
    {
        public string Code { get; set; }
        public string ExpriredTime { get; set; }
        public string CreateTime { get; set; }
        public string PhoneNumber { get; set; }
    }
}
