using Microsoft.EntityFrameworkCore;

namespace MARShop.Infastructure.Persistence.Configurations.DataType
{
    internal static class DataTypeConfig
    {
        internal static void SetDataTypeConfig(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountBlogPostConfig());
            modelBuilder.ApplyConfiguration(new AccountConfig());
            modelBuilder.ApplyConfiguration(new BlogPostConfig());
            modelBuilder.ApplyConfiguration(new BlogPostTagConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.ApplyConfiguration(new TagConfig());
        }
    }
}
