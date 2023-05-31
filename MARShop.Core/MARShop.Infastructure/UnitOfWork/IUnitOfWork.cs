using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.Repositories.AppInfoRepository;
using MARShop.Infastructure.Repositories.Base;
using MARShop.Infastructure.Repositories.HistoryRepository;
using MARShop.Infastructure.Repositories.MediaRepository;
using MARShop.Infastructure.Repositories.ShopRepository;
using System;
using System.Threading.Tasks;

namespace MARShop.Infastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Accounts { get; }
        IAppInfoRepository AppInfos { get; }
        IHistoryRepository Histories { get; }
        IMediaRepository Medias { get; }
        IShopRepository Shops { get; }
        Task Save();
    }
}
