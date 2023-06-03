using MARShop.Infastructure.Repositories.AccountBlogPostRepository;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.BlogPostRepository;
using System;
using System.Threading.Tasks;

namespace MARShop.Infastructure.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IAccountRepository Accounts { get; }
        IAccountBlogPostRepository AccountBlogPosts { get; }
        IBlogPostRepository BlogPosts { get; }
        Task SaveAsync();

    }
}
