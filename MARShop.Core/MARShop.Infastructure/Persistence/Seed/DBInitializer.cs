using Microsoft.EntityFrameworkCore;

namespace DevineShop.Infastructure.Persistence.Seed
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
