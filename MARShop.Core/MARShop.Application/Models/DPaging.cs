using System.Collections.Generic;

namespace MARShop.Application.Models
{
    public class DPaging<T> where T : class
    {
        public IReadOnlyList<T> Items { get; set; }
        public int TotalItems { get; set; }
    }
}
