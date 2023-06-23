using Microsoft.EntityFrameworkCore;

namespace MARShop.Infastructure.Persistence.Seed
{
    public static class DBInitializer
    {
        public static void SeedInitial(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedAccount();
            modelBuilder.SeedContact();
            modelBuilder.SeedEmailConfig();
        }
    }
}
