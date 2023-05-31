using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Infastructure.Repositories.AccountRepository;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AccountHandler.Queries.GetAccount
{
    public class GetAccountLoginQuery : IRequest<GetAccountLoginResponse>
    {
    }
    public class GetAccountLoginResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Role { get; set; }
    }
    public class GetAccountLoginQueryHandler : IRequestHandler<GetAccountLoginQuery, GetAccountLoginResponse>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAccountRepository _accountRepository;

        public GetAccountLoginQueryHandler(IHttpContextAccessor httpContextAccessor, IAccountRepository accountRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _accountRepository = accountRepository;
        }

        public async Task<GetAccountLoginResponse> Handle(GetAccountLoginQuery request, CancellationToken cancellationToken)
        {
            var id = _httpContextAccessor.HttpContext?.User?.FindFirst(DClaimType.Id).Value;

            var entity = await _accountRepository.DGetByIdAsync(Convert.ToInt32(id));
            var result = AccountMapper.Mapper.Map<GetAccountLoginResponse>(entity);
            return result;
        }
    }
}
