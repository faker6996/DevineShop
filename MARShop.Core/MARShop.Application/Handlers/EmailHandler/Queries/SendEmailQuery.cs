using MARShop.Application.Common;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.EmailHandler.Queries
{
    public class SendEmailQuery : IRequest<Respond>
    {
        public string Subject { get; set; }
        public string ToMail { get; set; }
        public string Body { get; set; }
    }

    public class SendEmailQueryHandler : IRequestHandler<SendEmailQuery, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public SendEmailQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond> Handle(SendEmailQuery request, CancellationToken cancellationToken)
        {
            var emailConfig =await _unitOfWork.EmailConfigs.DFistOrDefaultAsync();

            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress(emailConfig.Email),
                Subject = request.Subject,
                Body = request.Body,
                IsBodyHtml = true
            };
            mailMessage.To.Add(new MailAddress(request.ToMail));

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(emailConfig.Email, emailConfig.AppPassword),
                EnableSsl = true
            };

            smtpClient.Send(mailMessage);

            return Respond.Success();
        }
    }
}
