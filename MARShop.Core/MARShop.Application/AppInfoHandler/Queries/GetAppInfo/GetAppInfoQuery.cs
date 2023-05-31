using MARShop.Application.Mapper;
using MARShop.Infastructure.Repositories.AppInfoRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AppInfoHandler.Queries.GetAppInfo
{
    public class GetAppInfoQuery : IRequest<GetAppInfoResponse>
    {
    }

    public class GetAppInfoResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class GetAppInfoQueryHandler:IRequestHandler<GetAppInfoQuery, GetAppInfoResponse>
    {
        private readonly IAppInfoRepository _appInfoRepository;

        public GetAppInfoQueryHandler(IAppInfoRepository appInfoRepository)
        {
            _appInfoRepository = appInfoRepository;
        }

        public async Task<GetAppInfoResponse> Handle(GetAppInfoQuery request, CancellationToken cancellationToken)
        {
            var entity= await _appInfoRepository.GetAppInfoAsync();
            return AppInfoMapper.Mapper.Map<GetAppInfoResponse>(entity);
        }
    }
}
