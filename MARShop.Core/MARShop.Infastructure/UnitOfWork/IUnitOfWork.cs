using MARShop.Infastructure.Repositories.AccountBlogPostRepository;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.BlogPostRepository;
using MARShop.Infastructure.Repositories.BlogPostTagRepository;
using MARShop.Infastructure.Repositories.CommentRepository;
using MARShop.Infastructure.Repositories.ContactRepository;
using MARShop.Infastructure.Repositories.EmailConfigRepository;
using MARShop.Infastructure.Repositories.NotifyRepository;
using MARShop.Infastructure.Repositories.TagRepository;
using System;
using System.Threading.Tasks;

namespace MARShop.Infastructure.UnitOfWork
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
