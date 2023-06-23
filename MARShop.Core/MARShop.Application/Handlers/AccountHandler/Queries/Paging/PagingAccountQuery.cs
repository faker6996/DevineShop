using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Core.Common;
using MARShop.Core.Enum;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.AccountHandler.Queries.Paging
{
    public class PagingAccountQuery : IRequest<Respond<Paging<AccountRespond>>>
    {
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public string KeyWord { get; set; }
    }

    public class AccountRespond
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LinkWeb { get; set; }
        public bool IsSendEmailWhenHaveNewPost { get; set; }
    }

    public class PagingAccountQueryHandler : IRequestHandler<PagingAccountQuery, Respond<Paging<AccountRespond>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public PagingAccountQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<Paging<AccountRespond>>> Handle(PagingAccountQuery request, CancellationToken cancellationToken)
        {
            var accounts = _unitOfWork
                            .Accounts
                            .DGet(a => a.Name.Search(request.KeyWord)
                                    || a.UserName.Search(request.KeyWord)
                                    || a.Email.Search(request.KeyWord)
                                    || a.LinkWeb.Search(request.KeyWord)
                                    ).OrderByDescending(a => a.Created).Where(a => a.Role == nameof(Role.Client));

            var accounstSkipTake = accounts
                                     .Skip(request.PerPage * (request.CurrentPage - 1))
                                     .Take(request.PerPage)
                                     .ToList();

            var accountsRespond = AccountMapper.Mapper.Map<List<AccountRespond>>(accounstSkipTake);
            var totalRecord = accounts.Count();

            var paging = new Paging<AccountRespond>()
            {
                Total = totalRecord,
                PerPage = request.PerPage,
                CurrentPage = request.CurrentPage,
                Items = accountsRespond
            };

            return Respond<Paging<AccountRespond>>.Success(paging);
        }
    }
}
