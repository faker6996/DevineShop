using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;

namespace DevineShop.Infastructure.Repositories.BlogPostTagRepository
{
    public class BlogPostTagRepository: Repository<BlogPostTag>, IBlogPostTagRepository
    {
        public BlogPostTagRepository(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
