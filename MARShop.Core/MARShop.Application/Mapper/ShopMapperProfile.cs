using AutoMapper;
using MARShop.Application.ShopHandler.Commands.CreateShop;
using MARShop.Application.ShopHandler.Commands.UpdateShop;
using MARShop.Application.ShopHandler.Queries.GetShop;
using MARShop.Application.ShopHandler.Queries.GetShopPaging;
using MARShop.Core.Entities;

namespace MARShop.Application.Mapper
{
    public class ShopMapperProfile : Profile
    {
        public ShopMapperProfile()
        {
            CreateMap<Shop, CreateShopCommand>().ReverseMap();
            CreateMap<Shop, UpdateShopCommand>().ReverseMap();
            CreateMap<Shop, GetShopResponse>().ReverseMap();
            CreateMap<Shop, GetShopPagingResponse>().ReverseMap();
        }
    }
}
