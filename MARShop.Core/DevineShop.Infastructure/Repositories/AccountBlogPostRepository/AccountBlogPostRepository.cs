using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;

namespace DevineShop.Infastructure.Repositories.AccountBlogPostRepository
{
    public class AccountBlogPostRepository : Repository<AccountBlogPost>, IAccountBlogPostRepository
    {
        public AccountBlogPostRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
