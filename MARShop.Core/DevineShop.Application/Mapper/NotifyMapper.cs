using AutoMapper;
using DevineShop.Application.Handlers.NotifyHandler.Commands.Create;
using DevineShop.Application.Handlers.NotifyHandler.Queries.Paging;
using DevineShop.Core.Entities;
using System;

namespace DevineShop.Application.Mapper
{
    public class NotifyMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<NotifyMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class NotifyMappingProfile : Profile
    {
        public NotifyMappingProfile()
        {
            CreateMap<CreateNotifyCommand, Notify>();
            CreateMap<Notify, NotifyRespond>();
        }
    }
}
