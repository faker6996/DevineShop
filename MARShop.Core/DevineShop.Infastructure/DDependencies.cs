using DevineShop.Infastructure.Repositories.AccountBlogPostRepository;
using DevineShop.Infastructure.Repositories.AccountRepository;
using DevineShop.Infastructure.Repositories.Base;
using DevineShop.Infastructure.Repositories.BlogPostRepository;
using DevineShop.Infastructure.Repositories.BlogPostTagRepository;
using DevineShop.Infastructure.Repositories.CommentRepository;
using DevineShop.Infastructure.Repositories.TagRepository;
using DevineShop.Infastructure.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace DevineShop.Infastructure
{
    public static class DDependencies
    {
        public static void AddRepositoriesAndUnitOfWork( this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<ITagRepository, TagRepository>();
            services.AddTransient<IBlogPostTagRepository, BlogPostTagRepository>();
            services.AddTransient<IBlogPostRepository, BlogPostRepository>();
            services.AddTransient<IAccountBlogPostRepository, AccountBlogPostRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
    }
}
