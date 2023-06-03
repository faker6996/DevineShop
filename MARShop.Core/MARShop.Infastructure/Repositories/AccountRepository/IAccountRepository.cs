using MARShop.Core.Entities;
using MARShop.Infastructure.Common;
using MARShop.Infastructure.Repositories.Base;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.AccountRepository
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> CheckAuth(string userName, string password);
        Task ChangePassword(int id, string oldPassword, string newPassword);
        Task<Respond<Account>> GetPagingAccountAsync(int skip, int pageSize, string keyWord);
    }
}
