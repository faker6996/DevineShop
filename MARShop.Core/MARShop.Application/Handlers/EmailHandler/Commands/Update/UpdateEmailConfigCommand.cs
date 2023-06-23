using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.EmailHandler.Commands.Update
{
    public class UpdateEmailConfigCommand:IRequest<Respond>
    {
        public string Email { get; set; }
        public string AppPassword { get; set; }
    }

    public class UpdateEmailConfigCommandHandler : IRequestHandler<UpdateEmailConfigCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateEmailConfigCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond> Handle(UpdateEmailConfigCommand request, CancellationToken cancellationToken)
        {
            var emailConfig = await _unitOfWork.EmailConfigs.DFistOrDefaultAsync();

            if (emailConfig == null) throw new AppException("Lỗi không có bản ghi");

            emailConfig.Email = request.Email;
            emailConfig.AppPassword = request.AppPassword;

            await _unitOfWork.EmailConfigs.DUpdateAsync(emailConfig);

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
