using MARShop.Application.Common;
using MARShop.Application.Handlers.NotifyHandler.Commands.Create;
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
        private readonly IMediator _mediator;

        public CreateAccountClientCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public async Task<Respond> Handle(CreateAccountClientCommand request, CancellationToken cancellationToken)
        {
            var account = AccountMapper.Mapper.Map<Account>(request);
            account.Role = nameof(Role.Client);
            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);

            if (await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.UserName == account.UserName) != null)
                throw new AppException("Tên tài khoản đã tồn tại");

            if (await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == account.Email) != null)
                throw new AppException("Email không tồn tại trong hệ thống");

            await _unitOfWork.Accounts.DAddAsync(account);

            await _unitOfWork.SaveAsync();

            var notifyCommand = new CreateNotifyCommand()
            {
                Type = nameof(NotifyType.BlogPost),
                Content = $"Bạn {account.Name} có Email là {account.Email} đã đăng ký tài khoản",
                Title = "Thông báo đăng ký tài khoản",
                IsRead = false
            };

            await _mediator.Send(notifyCommand);


            return Respond.Success();
        }
    }
}
