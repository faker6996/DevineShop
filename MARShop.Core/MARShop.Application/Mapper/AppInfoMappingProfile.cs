using AutoMapper;
using MARShop.Application.AppInfoHandler.Commands.UpdateInfo;
using MARShop.Application.AppInfoHandler.Queries.GetAppInfo;
using MARShop.Core.Entities;

namespace MARShop.Application.Mapper
{
    public class AppInfoMappingProfile : Profile
    {
        public AppInfoMappingProfile()
        {
            CreateMap<AppInfo, UpdateAppInfoCommand>().ReverseMap();
            CreateMap<AppInfo, GetAppInfoResponse>().ReverseMap();
        }                                                           
    }
}
