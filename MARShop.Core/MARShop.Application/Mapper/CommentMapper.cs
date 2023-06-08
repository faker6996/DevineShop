using AutoMapper;
using MARShop.Application.Handlers.CommentHandler.Commands.Create;
using MARShop.Core.Entities;
using System;

namespace MARShop.Application.Mapper
{
    public class CommentMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<CommentMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<CreateCommentCommand, Comment>();
        }
    }
}
