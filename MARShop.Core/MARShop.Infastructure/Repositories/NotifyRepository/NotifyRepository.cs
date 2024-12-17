using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;

namespace DevineShop.Infastructure.Repositories.NotifyRepository
{
    public class NotifyRepository: Repository<Notify>,INotifyRepository
    {
        public NotifyRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
