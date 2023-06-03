using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;

namespace MARShop.Infastructure.Repositories.AccountBlogPostRepository
{
    public class AccountBlogPostRepository : Repository<AccountBlogPost>, IAccountBlogPostRepository
    {
        public AccountBlogPostRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
