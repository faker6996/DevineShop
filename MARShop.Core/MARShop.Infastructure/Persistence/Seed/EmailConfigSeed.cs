using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MARShop.Infastructure.Persistence.Seed
{
    public static class EmailConfigSeed
    {
        public static void SeedEmailConfig(this ModelBuilder modelBuilder)
        {
            IList<EmailConfig> emailConfigs = new List<EmailConfig>();

            var emailConfig = new EmailConfig()
            {
                Created = DateTime.Now,
                Id = 1,
                IsDelete = false,
                LastModified = DateTime.Now,
                Email= "kieuminhduc02@gmail.com",
                AppPassword= "ybri advf vvni efko"
            };
            emailConfigs.Add(emailConfig);

            modelBuilder.Entity<EmailConfig>().HasData(emailConfigs);
        }
    }
}
