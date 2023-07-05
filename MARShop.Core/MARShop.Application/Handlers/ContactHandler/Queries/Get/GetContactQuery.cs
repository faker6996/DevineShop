using MARShop.Application.Common;
using MARShop.Application.Mapper;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.ContactHandler.Queries.Get
{
    public class GetContactQuery:IRequest<Respond<GetContactRespond>>
    {
    }

    public class GetContactRespond
    {
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Email { get; set; }
        public string Zalo { get; set; }
    }

    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, Respond<GetContactRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetContactQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<GetContactRespond>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var contact = await _unitOfWork.Contacts.DFistOrDefaultAsync();

            if (contact == null) throw new AppException("Bản ghi không tồn tại !");

            var contactRespond = ContactMapper.Mapper.Map<GetContactRespond>(contact);

            return Respond<GetContactRespond>.Success(contactRespond);
        }
    }
}
