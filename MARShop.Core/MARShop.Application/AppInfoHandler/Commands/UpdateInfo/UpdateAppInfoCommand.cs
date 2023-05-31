using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.AppInfoRepository;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AppInfoHandler.Commands.UpdateInfo
{
    public class UpdateAppInfoCommand : IRequest<DResult>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class UpdateAppInfoCommandHandler : IRequestHandler<UpdateAppInfoCommand, DResult>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateAppInfoCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DResult> Handle(UpdateAppInfoCommand request, CancellationToken cancellationToken)
        {
            var entity = AppInfoMapper.Mapper.Map<AppInfo>(request);
            await _unitOfWork.AppInfos.UpdateAppInfoAsync(entity);
            await _unitOfWork.Save();
            return DResult.Success();
        }
    }
}
