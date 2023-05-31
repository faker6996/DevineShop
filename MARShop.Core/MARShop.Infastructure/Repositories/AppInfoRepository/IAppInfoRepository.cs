using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.Base;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.AppInfoRepository
{
    public interface IAppInfoRepository : IRepository<AppInfo>
    {
        Task<AppInfo> GetAppInfoAsync();
        Task UpdateAppInfoAsync(AppInfo appInfo);
    }
}
