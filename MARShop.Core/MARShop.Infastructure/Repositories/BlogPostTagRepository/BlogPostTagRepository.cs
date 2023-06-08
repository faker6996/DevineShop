using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;

namespace MARShop.Infastructure.Repositories.BlogPostTagRepository
{
    public class BlogPostTagRepository: Repository<BlogPostTag>, IBlogPostTagRepository
    {
        public BlogPostTagRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
