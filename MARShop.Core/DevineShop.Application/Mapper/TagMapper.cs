using AutoMapper;
using DevineShop.Application.Handlers.TagHandler.Commands.Create;
using DevineShop.Application.Handlers.TagHandler.Queries.All;
using DevineShop.Core.Entities;
using System;

namespace DevineShop.Application.Mapper
{
    public class TagMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<TagMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class TagMappingProfile : Profile
    {
        public TagMappingProfile()
        {
            CreateMap<CreateTagCommand, Tag>();
            CreateMap<Tag, TagRespond>();
        }
    }
}
