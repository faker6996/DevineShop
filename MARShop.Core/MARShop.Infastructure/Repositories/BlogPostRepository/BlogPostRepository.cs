using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;

namespace DevineShop.Infastructure.Repositories.BlogPostRepository
{
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
