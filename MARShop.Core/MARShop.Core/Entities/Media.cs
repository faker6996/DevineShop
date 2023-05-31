using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class Media : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageIdentity { get; set; }
        public string ImageIdentityIdInVuforia { get; set; }
        public int ImageIdentityWidth { get; set; }
        public string MediaFile { get; set; }
    }
}
