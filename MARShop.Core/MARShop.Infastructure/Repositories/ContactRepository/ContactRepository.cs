using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;

namespace DevineShop.Infastructure.Repositories.ContactRepository
{
    public class ContactRepository: Repository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
