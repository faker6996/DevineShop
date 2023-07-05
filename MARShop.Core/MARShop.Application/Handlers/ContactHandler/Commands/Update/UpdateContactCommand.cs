using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.ContactHandler.Commands.Update
{
    public class UpdateContactCommand : IRequest<Respond>
    {
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Email { get; set; }
        public string Zalo { get; set; }
    }

    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateContactCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _unitOfWork.Contacts.DFistOrDefaultAsync();

            if (contact == null) throw new AppException("Lỗi không có bản ghi");

            contact.Facebook = request.Facebook;
            contact.Linkedin = request.Linkedin;
            contact.Email = request.Email;
            contact.Zalo = request.Zalo;

            await _unitOfWork.Contacts.DUpdateAsync(contact);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
