using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;

namespace MARShop.Infastructure.Repositories.AccountRoleRepository
{
    public class AccountRoleRepository : Repository<AccountRole>, IAccountRoleRepository
    {
        public AccountRoleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
