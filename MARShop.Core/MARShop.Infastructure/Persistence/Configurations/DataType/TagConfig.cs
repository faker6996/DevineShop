using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MARShop.Infastructure.Persistence.Configurations.DataType
{
    internal class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(tag => tag.Id).IsRequired();
            builder.Property(tag => tag.Title).IsRequired();
        }
    }
}
