using System.Collections.Generic;

namespace MARShop.Infastructure.Common
{
    public class Respond<T> where T : class
    {
        public IEnumerable<T> Items { get; set; }
        public int Total { get; set; }

        public static Respond<T> New(IEnumerable<T> items, int total)
        {
            return new Respond<T> { Items = items, Total = total };
        }
    }
}
