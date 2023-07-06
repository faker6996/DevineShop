using AutoMapper;
using MARShop.Application.Handlers.AccountBlogPostHandler.Queries.Get;
using MARShop.Application.Handlers.BlogPostHandler.Commands.Update;
using MARShop.Core.Entities;
using System;

namespace MARShop.Application.Mapper
{
    public class AccountBlogPostMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<AccountBlogPostProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class AccountBlogPostProfile: Profile
    {
        public AccountBlogPostProfile()
        {
            CreateMap<UpdateLikeBlogPostCommand, AccountBlogPost>()
                .ForMember(dest=>dest.AccountId,opt=> opt.Ignore())
                .ForMember(dest=>dest.BlogPostId, opt=> opt.Ignore());
            CreateMap<AccountBlogPost, AccountBlogPostRespond>();
        }
    }
}
