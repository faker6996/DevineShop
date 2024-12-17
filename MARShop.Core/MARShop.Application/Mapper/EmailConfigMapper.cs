using AutoMapper;
using DevineShop.Application.Handlers.EmailHandler.Queries.Get;
using DevineShop.Core.Entities;
using System;

namespace DevineShop.Application.Mapper
{
    public class EmailConfigMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<EmailConfigMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class EmailConfigMappingProfile : Profile
    {
        public EmailConfigMappingProfile()
        {
            CreateMap<EmailConfig, EmailConfigRespond>();
        }
    }
}
