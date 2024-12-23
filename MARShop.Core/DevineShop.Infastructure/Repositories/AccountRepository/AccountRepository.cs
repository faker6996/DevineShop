using DevineShop.Core.Common;
using DevineShop.Core.Entities;
using DevineShop.Infastructure.Common;
using DevineShop.Infastructure.Persistence;
using DevineShop.Infastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DevineShop.Infastructure.Repositories.AccountRepository
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext context) : base(context) { }
        public async Task ChangePassword(int id, string oldPassword, string newPassword)
        {
            var account = await DFistOrDefaultAsync(a => a.Id.Equals(id));
            if (BCrypt.Net.BCrypt.Verify(oldPassword, account.Password))
            {
                account.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            }
        }

        public async Task<Account> CheckAuth(string userName, string password)
        {
            var account = await DFistOrDefaultAsync(a => a.UserName.Equals(userName));
            return BCrypt.Net.BCrypt.Verify(password, account.Password) ? account : null;
        }

        public async Task<Respond<Account>> GetPagingAccountAsync(int skip, int pageSize, string keyWord)
        {
            if (keyWord == null) keyWord = "";
            var accountsMatch = DGetAll().Where(a => a.UserName.Search(keyWord)
                                                 || a.Email.Search(keyWord)
                                                 || a.Name.Search(keyWord)
                                                 || a.LinkWeb.Search(keyWord));
            var total = accountsMatch.Count();
            var accountsMatchPaging = await accountsMatch.Skip(skip).Take(pageSize).ToListAsync();
            return Respond<Account>.New(accountsMatchPaging, total);
        }
    }
}
