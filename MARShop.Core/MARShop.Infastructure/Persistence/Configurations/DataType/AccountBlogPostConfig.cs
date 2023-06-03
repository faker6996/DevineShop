using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MARShop.Infastructure.Persistence.Configurations.DataType
{
    internal class AccountBlogPostConfig : IEntityTypeConfiguration<AccountBlogPost>
    {
        public void Configure(EntityTypeBuilder<AccountBlogPost> builder)
        {
            builder.Property(accountBlogPost => accountBlogPost.Id).IsRequired();
            builder.Property(accountBlogPost => accountBlogPost.AccountId).IsRequired();
            builder.Property(accountBlogPost => accountBlogPost.BlogPostId).IsRequired();
        }
    }
}
