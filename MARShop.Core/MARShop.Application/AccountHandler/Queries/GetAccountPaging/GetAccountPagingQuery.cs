using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.AccountRepository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AccountHandler.Queries.GetAccountPaging
{
    public class GetAccountPagingQuery : IRequest<DResult<DPaging<GetAccountPagingResponse>>>
    {
        public int Skip { get; set; }
        public int PageSize { get; set; }
        public string KeyWord { get; set; }
    }
    public class GetAccountPagingResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Role { get; set; }
    }
    public class GetShopPagingQueryHandler : IRequestHandler<GetAccountPagingQuery, DResult<DPaging<GetAccountPagingResponse>>>
    {
        private readonly IAccountRepository _accountRepository;

        public GetShopPagingQueryHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<DResult<DPaging<GetAccountPagingResponse>>> Handle(GetAccountPagingQuery request, CancellationToken cancellationToken)
        {
            var entities = await _accountRepository.GetPagingAccountAsync(request.Skip, request.PageSize,request.KeyWord);
            var items = AccountMapper.Mapper.Map<List<GetAccountPagingResponse>>(entities);
            var total = await _accountRepository.DGetTotalAccountWithKeyWordConditionAsync(request.KeyWord);

            var result = new DPaging<GetAccountPagingResponse>()
            {
                Items = items,

                TotalItems = total,
            };

            return DResult<DPaging<GetAccountPagingResponse>>.Success(result);
        }
    }
   
}
