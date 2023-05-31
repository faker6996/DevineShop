using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.AppInfoRepository;
using MARShop.Infastructure.Repositories.HistoryRepository;
using MARShop.Infastructure.Repositories.MediaRepository;
using MARShop.Infastructure.Repositories.ShopRepository;
using System;
using System.Threading.Tasks;

namespace MARShop.Infastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;
        private IAccountRepository _accounts;
        private IAppInfoRepository _appInfos;
        private IHistoryRepository _histories;
        private IMediaRepository _medias;
        private IShopRepository _shops;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IAccountRepository Accounts => _accounts??=new AccountRepository(_context);

        public IAppInfoRepository AppInfos => _appInfos??= new AppInfoRepository(_context);

        public IHistoryRepository Histories => _histories ??= new HistoryRepository(_context);

        public IMediaRepository Medias => _medias ??= new MediaRepository(_context);

        public IShopRepository Shops => _shops ??= new ShopRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
