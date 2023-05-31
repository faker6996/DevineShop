using AutoMapper;
using MARShop.Application.HistoryHandler.Commands.CreateHistory;
using MARShop.Core.Entities;

namespace MARShop.Application.Mapper
{
    public class HistoryMappingProfile : Profile
    {
        public HistoryMappingProfile()
        {
            CreateMap<History, CreateHistoryCommand>().ReverseMap();
        }
    }
}
