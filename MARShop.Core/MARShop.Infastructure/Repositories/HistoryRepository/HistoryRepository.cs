using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.HistoryRepository
{
    public class HistoryRepository : Repository<History>, IHistoryRepository
    {
        public HistoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IReadOnlyList<History>> GetPagingHistoriesAsync(int skip, int pageSize)
        {
            var histories = await DGetAllAsync();
            return histories.OrderByDescending(a=>a.Created).Skip(skip).Take(pageSize).ToList();
        }
    }
}
