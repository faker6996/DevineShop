using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;
using MARShop.Infastructure.Share;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.ShopRepository
{
    public class ShopRepository : Repository<Shop>, IShopRepository
    {
        public ShopRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IReadOnlyList<Shop>> GetPagingShopsAsync(int skip, int pageSize,string keyWord)
        {

            var shops = await DGetAllAsync();
            return shops.Where(a => IsMatchKeyWord(a, keyWord)).Skip(skip).Take(pageSize).ToList();
        }

        public async Task<IReadOnlyList<Shop>> GetPagingShopsAsync(int skip, int pageSize,string keyWord, string[] startLatLong)
        {

            var constValue = 57.2957795130823D;
            var constValue2 = 3958.75586574D;
            var searchWithin = 20;

            var latSearch = startLatLong[0];
            var longSearch = startLatLong[1];

            var items = _context.Set<Shop>().Where(a => a.IsDelete == false).ToList();

            var itemAfterSort = (from store in items
                                 let temp =
                                 Math.Sin(Convert.ToDouble(DConvertor.LatLongToArray(store.LatLong)[0]) / constValue) * Math.Sin(Convert.ToDouble(latSearch) / constValue) +
                                                             Math.Cos(Convert.ToDouble(DConvertor.LatLongToArray(store.LatLong)[0]) / constValue) *
                                                             Math.Cos(Convert.ToDouble(latSearch) / constValue) *
                                                             Math.Cos((Convert.ToDouble(DConvertor.LatLongToArray(store.LatLong)[1]) / constValue) - 
                                                             (Convert.ToDouble(DConvertor.LatLongToArray(store.LatLong)[1]) / constValue))
                                 let calMiles = (constValue2 * Math.Acos(temp > 1 ? 1 : (temp < -1 ? -1 : temp)))
                                 where (Convert.ToDouble(DConvertor.LatLongToArray(store.LatLong)[0]) > 0 && Convert.ToDouble(DConvertor.LatLongToArray(store.LatLong)[1]) > 0)
                                 orderby calMiles

                                 select new Shop
                                 {
                                     Id = store.Id,
                                     CloseTime = store.CloseTime,
                                     LatLong = store.LatLong,
                                     Description = store.Description,
                                     Location = store.Location,
                                     Name = store.Name,
                                     OpenTime = store.OpenTime,
                                     IsDelete = store.IsDelete,
                                 });

            return itemAfterSort.Where(a=>IsMatchKeyWord(a,keyWord)).Skip(skip).Take(pageSize).ToList();
        }
        private bool IsMatchKeyWord(Shop shop, string keyWord)
        {
            if (keyWord == null) keyWord = "";

            return shop.Name.ToLower().Contains(keyWord.ToLower()) || 
                   shop.Description.ToLower().Contains(keyWord.ToLower()) ||
                   shop.Location.ToLower().Contains(keyWord.ToLower()) ||
                   shop.LatLong.ToLower().Contains(keyWord.ToLower());
        }
        public async Task<int> DGetTotalShopWithKeyWordConditionAsync(string keyWord)
        {
            var medias = await DGetAllAsync();
            return medias.Where(a => a.IsDelete == false).Where(a => IsMatchKeyWord(a, keyWord)).Count();
        }
    }
}
