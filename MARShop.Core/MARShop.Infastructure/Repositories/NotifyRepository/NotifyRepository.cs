using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;

namespace MARShop.Infastructure.Repositories.NotifyRepository
{
    public class NotifyRepository: Repository<Notify>,INotifyRepository
    {
        public NotifyRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
