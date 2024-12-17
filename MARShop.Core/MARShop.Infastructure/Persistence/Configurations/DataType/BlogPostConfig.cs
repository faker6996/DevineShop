using DevineShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevineShop.Infastructure.Persistence.Configurations.DataType
{
    internal class BlogPostConfig : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.Property(blogPost => blogPost.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(blogPost => blogPost.Title).IsRequired();
            builder.Property(blogPost => blogPost.Content).IsRequired();
        }
    }
}
