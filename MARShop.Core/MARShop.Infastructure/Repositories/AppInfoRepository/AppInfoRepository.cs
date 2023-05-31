using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;
using System;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.AppInfoRepository
{
    public class AppInfoRepository : Repository<AppInfo>, IAppInfoRepository
    {
        public AppInfoRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<AppInfo> GetAppInfoAsync()
        {
            var appInfo = await DFistOrDefaultAsync();
            if (appInfo == null)
            {
                return new AppInfo();
            }
            return appInfo;
        }

        public async Task UpdateAppInfoAsync(AppInfo param)
        {
            if (await DGetTotalAsync() > 0)
            {
                var entity = await DFistOrDefaultAsync();
                entity.Title = param.Title;
                entity.Description = param.Description;
                await DUpdateAsync(entity);
            }
            else
            {
                await DAddAsync(param);
            }
        }
    }
}
