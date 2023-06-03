using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.AccountBlogPostRepository;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.BlogPostRepository;
using System;
using System.Threading.Tasks;

namespace MARShop.Infastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;
        public IAccountRepository _accounts;
        public IAccountBlogPostRepository _accountBlogPosts;
        public IBlogPostRepository _blogPostRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IAccountRepository Accounts => _accounts ?? new AccountRepository(_context);

        public IAccountBlogPostRepository AccountBlogPosts => _accountBlogPosts ?? new AccountBlogPostRepository(_context);
        public IBlogPostRepository BlogPosts => _blogPostRepository ?? new BlogPostRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _context?.SaveChangesAsync();
        }
    }
}
