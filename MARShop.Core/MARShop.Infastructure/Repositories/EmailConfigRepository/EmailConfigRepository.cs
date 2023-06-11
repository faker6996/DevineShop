using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;

namespace MARShop.Infastructure.Repositories.EmailConfigRepository
{
    public class EmailConfigRepository : Repository<EmailConfig>, IEmailConfigRepository
    {
        public EmailConfigRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
