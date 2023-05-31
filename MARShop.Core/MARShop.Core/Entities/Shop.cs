using MARShop.Core.Common;

namespace MARShop.Core.Entities
{
    public class Shop : AuditableEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string LatLong { get; set; }
        public string Description { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
    }
}