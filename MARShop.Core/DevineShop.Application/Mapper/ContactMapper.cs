using AutoMapper;
using DevineShop.Application.Handlers.ContactHandler.Queries.Get;
using DevineShop.Core.Entities;
using System;

namespace DevineShop.Application.Mapper
{
    public class ContactMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<ContactMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }

    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<Contact, GetContactRespond>();
        }
    }
}
