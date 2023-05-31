using AutoMapper;
using MARShop.Application.AccountHandler.Commands.CreateAccount;
using MARShop.Application.AccountHandler.Commands.UpdateAccount;
using MARShop.Application.AccountHandler.Queries.GetAccount;
using MARShop.Application.AccountHandler.Queries.GetAccountPaging;
using MARShop.Core.Entities;

namespace MARShop.Application.Mapper
{
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<Account, CreateAccountCommand>().ReverseMap();
            CreateMap<Account, UpdateAccountCommand>().ReverseMap();
            CreateMap<Account, GetAccountResponse>().ReverseMap();
            CreateMap<Account, GetAccountPagingResponse>().ReverseMap();
            CreateMap<Account, GetAccountLoginResponse>().ReverseMap();
        }
    }
}
