
using System.Collections.Generic;

namespace MARShop.Application.Common
{
    public class Paging<T>
    {
        public int Total { get; set; }
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public List<T> Items { get; set; }
    }
}
