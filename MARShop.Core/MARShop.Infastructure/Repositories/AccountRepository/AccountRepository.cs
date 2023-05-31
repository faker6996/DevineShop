using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.AccountRepository
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext context) : base(context)
        {

        }
        public async Task<Account> CheckAuth(string userName, string password)
        {
            var account = await DFistOrDefaultAsync(acc => acc.UserName.Equals(userName) && acc.Password.Equals(password));
            return account;
        }
        public async Task ChangePassword(int id, string oldPassword,string newPassword)
        {
            var account = await DFistOrDefaultAsync(acc => acc.Id == id  && acc.Password == oldPassword);
            account.Password = newPassword;
            await _context.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<Account>> GetPagingAccountAsync(int skip, int pageSize, string keyWord)
        {

            var accounts = await DGetAllAsync();
            return accounts.Where(a => IsMatchKeyWord(a, keyWord)).Skip(skip).Take(pageSize).ToList();
        }
        private bool IsMatchKeyWord(Account account, string keyWord = "")
        {
            if (keyWord == null) keyWord = "";

            return account.UserName.ToLower().Contains(keyWord.ToLower());
        }
        public async Task<int> DGetTotalAccountWithKeyWordConditionAsync(string keyWord)
        {
            var medias = await DGetAllAsync();
            return medias.Where(a => a.IsDelete == false).Where(a => IsMatchKeyWord(a, keyWord)).Count();
        }
    }
}
