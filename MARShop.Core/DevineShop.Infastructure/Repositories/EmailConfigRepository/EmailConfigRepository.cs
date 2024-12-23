using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;

namespace DevineShop.Infastructure.Repositories.EmailConfigRepository
{
    public class EmailConfigRepository : Repository<EmailConfig>, IEmailConfigRepository
    {
        public EmailConfigRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
