using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MARShop.Infastructure.Persistence.Configurations.DataType
{
    internal class BlogPostConfig : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.Property(blogPost => blogPost.Id).IsRequired();
            builder.Property(blogPost => blogPost.Title).IsRequired();
            builder.Property(blogPost => blogPost.Content).IsRequired();
        }
    }
}
