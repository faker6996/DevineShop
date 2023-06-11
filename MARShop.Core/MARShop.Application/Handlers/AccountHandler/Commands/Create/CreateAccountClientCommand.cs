using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Core.Enum;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.AccountHandler.Commands.Create
{
    public class CreateAccountClientCommand : IRequest<Respond>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string LinkWeb { get; set; }
        public string Name { get; set; }
        public bool IsSendEmailWhenHaveNewPost { get; set; }
    }

    public class CreateAccountClientCommandHandler : IRequestHandler<CreateAccountClientCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateAccountClientCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond> Handle(CreateAccountClientCommand request, CancellationToken cancellationToken)
        {
            var account = AccountMapper.Mapper.Map<Account>(request);
            account.Role = nameof(Role.Client);
            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);

            if (await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.UserName == account.UserName) != null)
                throw new AppException("username exist");

            if (await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == account.Email) != null)
                throw new AppException("email exist");

            await _unitOfWork.Accounts.DAddAsync(account);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
