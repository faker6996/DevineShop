using MARShop.Application.Common;
using MARShop.Application.Handlers.EmailHandler.Queries;
using MARShop.Application.Middleware;
using MARShop.Core.Common;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.AccountHandler.Commands.ChangePassword
{
    public class ResetPasswordCommand : IRequest<Respond>
    {
        public string Email { get; set; }
    }

    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public ResetPasswordCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public async Task<Respond> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == request.Email);

            if (account == null) throw new AppException("Email không có trong hệ thống");

            var randomPassword = GeneratePass.GenerateRandomPassword(5);

            account.Password = BCrypt.Net.BCrypt.HashPassword(randomPassword);
            await _unitOfWork.Accounts.DUpdateAsync(account);

            await _unitOfWork.SaveAsync();

            var emailQuery = new SendEmailQuery()
            {
                ToMail = account.Email,
                Subject = "KHÔI PHỤC MẬT KHẨU",
                Body = $"<body>\r\n<p>Xin chào,</p>\r\n<p>Chúng tôi đã nhận được yêu cầu khôi phục mật khẩu từ bạn. Bạn vui lòng đăng nhập tài khoản với mật khẩu sau: <b>{randomPassword}</b>, rồi sau đó bạn hãy thiết lập mật khẩu mới.</p>\r\n</body>"
            };

            await _mediator.Send(emailQuery);

            return Respond.Success();
        }
    }
}
