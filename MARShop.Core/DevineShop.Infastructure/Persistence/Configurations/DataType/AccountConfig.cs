using DevineShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevineShop.Infastructure.Persistence.Configurations.DataType
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            // Cấu hình Id tự tăng
            builder.Property(account => account.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // Thiết lập tự tăng
        }
    }
}
