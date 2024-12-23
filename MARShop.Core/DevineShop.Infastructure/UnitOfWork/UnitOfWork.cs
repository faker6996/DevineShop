using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.AccountBlogPostRepository;
using DevineShop.Infastructure.Repositories.AccountRepository;
using DevineShop.Infastructure.Repositories.BlogPostRepository;
using DevineShop.Infastructure.Repositories.BlogPostTagRepository;
using DevineShop.Infastructure.Repositories.CommentRepository;
using DevineShop.Infastructure.Repositories.ContactRepository;
using DevineShop.Infastructure.Repositories.EmailConfigRepository;
using DevineShop.Infastructure.Repositories.NotifyRepository;
using DevineShop.Infastructure.Repositories.TagRepository;
using System;
using System.Threading.Tasks;

namespace DevineShop.Infastructure.UnitOfWork
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
        public IEmailConfigRepository _emailConfigs;
        public IContactRepository _contacts;
        public INotifyRepository _notifies;
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
        public IEmailConfigRepository EmailConfigs => _emailConfigs ?? new EmailConfigRepository(_context);
        public IContactRepository Contacts => _contacts ?? new ContactRepository(_context);
        public INotifyRepository Notifies => _notifies ?? new NotifyRepository(_context);
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
