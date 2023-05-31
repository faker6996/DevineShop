using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.AccountRoleRepository;
using MARShop.Infastructure.Repositories.AppInfoRepository;
using MARShop.Infastructure.Repositories.Base;
using MARShop.Infastructure.Repositories.HistoryRepository;
using MARShop.Infastructure.Repositories.MediaRepository;
using MARShop.Infastructure.Repositories.PermissionRepository;
using MARShop.Infastructure.Repositories.RolePermissionRepository;
using MARShop.Infastructure.Repositories.RoleRepository;
using MARShop.Infastructure.Repositories.ShopRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MARShop.Infastructure
{
    public static class DDependencies
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IHistoryRepository, HistoryRepository>();
            services.AddTransient<IMediaRepository, MediaRepository>();
            services.AddTransient<IShopRepository, ShopRepository>();
            services.AddTransient<IAppInfoRepository, AppInfoRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IPermissionRepository, PermissionRepository>();
            services.AddTransient<IRolePermissionRepository, RolePermissionRepository>();
            services.AddTransient<IAccountRoleRepository, AccountRoleRepository>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
