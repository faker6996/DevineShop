using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MARShop.Infastructure.Persistence.Configurations.DataType
{
    internal class BlogPostTagConfig : IEntityTypeConfiguration<BlogPostTag>
    {
        public void Configure(EntityTypeBuilder<BlogPostTag> builder)
        {
            builder.Property(blogPostTag => blogPostTag.Id).IsRequired();
            builder.Property(blogPostTag => blogPostTag.BlogPostId).IsRequired();
            builder.Property(blogPostTag => blogPostTag.TagId).IsRequired();
        }
    }
}
