using MARShop.Application.Mapper;
using MARShop.Infastructure.Repositories.AccountRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AccountHandler.Queries.GetAccount
{
    public class GetAccountQuery : IRequest<GetAccountResponse>
    {
        public int Id { get; set; }

        public GetAccountQuery(int id)
        {
            Id = id;
        }
    }
    public class GetAccountResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
    public class GetShopQueryHandler : IRequestHandler<GetAccountQuery, GetAccountResponse>
    {
        private readonly IAccountRepository _accountRepository;

        public GetShopQueryHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<GetAccountResponse> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            var entity = await _accountRepository.DGetByIdAsync(request.Id);
            var result = AccountMapper.Mapper.Map<GetAccountResponse>(entity);
            return result;
        }
    }
}
