using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.ShopRepository
{
    public interface IShopRepository: IRepository<Shop>
    {
        Task<IReadOnlyList<Shop>> GetPagingShopsAsync(int skip, int pageSize, string keyWord, string[] startLatLong);
        Task<IReadOnlyList<Shop>> GetPagingShopsAsync(int skip, int pageSize, string keyWord);
        Task<int> DGetTotalShopWithKeyWordConditionAsync(string keyWord);
    }
}
