using MARShop.Infastructure.Repositories.AccountBlogPostRepository;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.Base;
using MARShop.Infastructure.Repositories.BlogPostRepository;
using MARShop.Infastructure.Repositories.BlogPostTagRepository;
using MARShop.Infastructure.Repositories.CommentRepository;
using MARShop.Infastructure.Repositories.TagRepository;
using MARShop.Infastructure.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace MARShop.Infastructure
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
