using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MARShop.Infastructure.Persistence.Configurations.DataType
{
    internal class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(comment => comment.Id).IsRequired();
            builder.Property(comment => comment.AccountId).IsRequired();
            builder.Property(comment => comment.BlogPostId).IsRequired();
        }
    }
}
