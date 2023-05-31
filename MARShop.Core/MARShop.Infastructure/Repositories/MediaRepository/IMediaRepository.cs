using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.MediaRepository
{
    public interface IMediaRepository: IRepository<Media>
    {
        Task<IReadOnlyList<Media>> DGetPagingMediaAsync(int skip, int pageSize, string keyWord);
        Task<int> DGetTotalMediaWithKeyWordConditionAsync(string keyWord);
    }
}
