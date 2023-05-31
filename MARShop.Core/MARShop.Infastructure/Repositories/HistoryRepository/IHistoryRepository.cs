using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.HistoryRepository
{
    public interface IHistoryRepository: IRepository<History>
    {
        Task<IReadOnlyList<History>> GetPagingHistoriesAsync(int skip, int pageSize);
    }
}
