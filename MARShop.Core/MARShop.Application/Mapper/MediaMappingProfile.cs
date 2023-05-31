using AutoMapper;
using MARShop.Application.AccountHandler.Queries.GetAccount;
using MARShop.Application.MediaHandler.Commands.CreateMedia;
using MARShop.Application.MediaHandler.Commands.UpdateMedia;
using MARShop.Application.MediaHandler.Queries.GetMedia;
using MARShop.Application.MediaHandler.Queries.GetMediaPaging;
using MARShop.Core.Entities;

namespace MARShop.Application.Mapper
{
    public class MediaMappingProfile : Profile
    {
        public MediaMappingProfile()
        {
            CreateMap<Media, CreateMediaCommand>().ReverseMap();
            CreateMap<GetMediaResponse, Media>().ReverseMap();
            CreateMap<GetMediaPagingResponse, Media>().ReverseMap();
            CreateMap<UpdateMediaCommand, Media>().ReverseMap();
        }
    }
}
