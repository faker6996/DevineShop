using AutoMapper;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Create;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Update;
using MARShop.Application.Handlers.BlogPostHandler.Queries.Get;
using MARShop.Core.Entities;
using System;

namespace MARShop.Application.Mapper
{
    public class BlogPostMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<BlogPostMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class BlogPostMappingProfile : Profile
    {
        public BlogPostMappingProfile()
        {
            CreateMap<CreateBlogPostCommand, BlogPost>();
            CreateMap<UpdateBlogPostCommand, BlogPost>()
                .ForMember(dest=>dest.Id, opt=>opt.Ignore());
            CreateMap<BlogPost, BlogPostRespond>();
            CreateMap<BlogPost, BlogPostBySlugRespond>();
        }
    }
}
