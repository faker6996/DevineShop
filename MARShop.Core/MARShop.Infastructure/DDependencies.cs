using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.Base;
using MARShop.Infastructure.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace MARShop.Infastructure
{
    public static class DDependencies
    {
        public static void AddRepositoriesAndUnitOfWork( this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
    }
}
