using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.MediaRepository
{
    public class MediaRepository : Repository<Media>, IMediaRepository
    {
        public MediaRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<IReadOnlyList<Media>> DGetPagingMediaAsync(int skip, int pageSize, string keyWord)
        {
            var medias = await DGetAllAsync();
            return medias.Where(a => IsMatchKeyWord(a, keyWord)).Skip(skip).Take(pageSize).ToList();
        }
        private bool IsMatchKeyWord(Media media, string keyWord)
        {
            if (keyWord == null) keyWord = "";
            return media.Name.ToLower().Contains(keyWord.ToLower()) || media.Description.ToLower().Contains(keyWord.ToLower());
        }
        public async Task<int> DGetTotalMediaWithKeyWordConditionAsync(string keyWord)
        {
            var medias = await DGetAllAsync();
            return medias.Where(a => a.IsDelete == false).Where(a => IsMatchKeyWord(a, keyWord)).Count();
        }
    }
}
