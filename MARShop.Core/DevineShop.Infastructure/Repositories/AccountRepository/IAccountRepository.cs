using DevineShop.Core.Entities;
using DevineShop.Infastructure.Common;
using DevineShop.Infastructure.Repositories.Base;
using System.Threading.Tasks;

namespace DevineShop.Infastructure.Repositories.AccountRepository
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> CheckAuth(string userName, string password);
        Task ChangePassword(int id, string oldPassword, string newPassword);
        Task<Respond<Account>> GetPagingAccountAsync(int skip, int pageSize, string keyWord);
    }
}
