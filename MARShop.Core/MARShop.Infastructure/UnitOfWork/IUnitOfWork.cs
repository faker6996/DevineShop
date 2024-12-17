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
    public interface IUnitOfWork : IDisposable
    {
        ITagRepository Tags { get; }
        IBlogPostTagRepository BlogPostTags { get; }
        IBlogPostRepository BlogPosts { get; }
        IAccountBlogPostRepository AccountBlogPosts { get; }
        IAccountRepository Accounts { get; }
        ICommentRepository Comments { get; }
        IEmailConfigRepository EmailConfigs { get; }
        IContactRepository Contacts { get; }
        INotifyRepository Notifies { get; }
        Task SaveAsync();

    }
}
