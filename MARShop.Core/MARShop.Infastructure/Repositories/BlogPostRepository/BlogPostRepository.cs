using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;

namespace MARShop.Infastructure.Repositories.BlogPostRepository
{
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
