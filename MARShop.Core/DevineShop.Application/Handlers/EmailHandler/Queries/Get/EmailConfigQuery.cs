using DevineShop.Application.Common;
using DevineShop.Application.Mapper;
using DevineShop.Application.Middleware;
using DevineShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevineShop.Application.Handlers.EmailHandler.Queries.Get
{
    public class EmailConfigQuery: IRequest<Respond<EmailConfigRespond>>
    {
    }

    public class EmailConfigRespond
    {
        public string Email { get; set; }
        public string AppPassword { get; set; }
    }

    public class EmailConfigQueryHandler : IRequestHandler<EmailConfigQuery, Respond<EmailConfigRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmailConfigQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<EmailConfigRespond>> Handle(EmailConfigQuery request, CancellationToken cancellationToken)
        {
            var emailConfig = await _unitOfWork.EmailConfigs.DFistOrDefaultAsync();

            if (emailConfig == null) throw new AppException("Bản ghi không tồn tại !");

            var emailConfigRespond = EmailConfigMapper.Mapper.Map<EmailConfigRespond>(emailConfig);

            return Respond<EmailConfigRespond>.Success(emailConfigRespond);
        }
    }
}
