using AutoMapper;
using DevineShop.Application.Handlers.AccountHandler.Commands.Create;
using DevineShop.Application.Handlers.AccountHandler.Commands.CreateOrUpdate;
using DevineShop.Application.Handlers.AccountHandler.Queries.Paging;
using DevineShop.Core.Entities;
using System;

namespace DevineShop.Application.Mapper
{
    public class AccountMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<AccountMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<CreateOrUpdateClientCommand, Account>();
            CreateMap<CreateAccountClientCommand, Account>();
            CreateMap<Account, AccountRespond>();
        }
    }
}
