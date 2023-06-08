using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.AccountBlogPostRepository;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.BlogPostRepository;
using MARShop.Infastructure.Repositories.BlogPostTagRepository;
using MARShop.Infastructure.Repositories.CommentRepository;
using MARShop.Infastructure.Repositories.TagRepository;
using System;
using System.Threading.Tasks;

namespace MARShop.Infastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;
        public ITagRepository _tags;
        public IBlogPostTagRepository _blogPostTags;
        public IBlogPostRepository _blogPosts;
        public IAccountBlogPostRepository _accountBlogPosts;
        public IAccountRepository _accounts;
        public ICommentRepository _comments;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public ITagRepository Tags => _tags ?? new TagRepository(_context);
        public IBlogPostTagRepository BlogPostTags => _blogPostTags ?? new BlogPostTagRepository(_context);
        public IBlogPostRepository BlogPosts => _blogPosts ?? new BlogPostRepository(_context);
        public IAccountBlogPostRepository AccountBlogPosts => _accountBlogPosts ?? new AccountBlogPostRepository(_context);
        public IAccountRepository Accounts => _accounts ?? new AccountRepository(_context);
        public ICommentRepository Comments => _comments ?? new CommentRepository(_context);

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
