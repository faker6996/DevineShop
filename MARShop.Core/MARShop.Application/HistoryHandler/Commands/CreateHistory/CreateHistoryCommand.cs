using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Infastructure.Repositories.HistoryRepository;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.HistoryHandler.Commands.CreateHistory
{
    public class CreateHistoryCommand : IRequest<DResult>
    {
        public string PhoneNumber { get; set; }
        public string ImageTargetId { get; set; }
    }

    public class CreateHistoryCommandHandler : IRequestHandler<CreateHistoryCommand, DResult>
    {
        private readonly IHistoryRepository _historyRepository;
        private readonly IMediaRepository _mediaRepository;

        public CreateHistoryCommandHandler(IHistoryRepository historyRepository, IMediaRepository mediaRepository)
        {
            _historyRepository = historyRepository;
            _mediaRepository = mediaRepository;
        }

        public async Task<DResult> Handle(CreateHistoryCommand request, CancellationToken cancellationToken)
        {
            var mediaId =(await _mediaRepository.DFistOrDefaultAsync(a => a.ImageIdentityIdInVuforia.Equals(request.ImageTargetId))).Id;
            Console.WriteLine("Image Identity Id: " + request.ImageTargetId);
            Console.WriteLine("Media Id: " + mediaId);
            var entity = HistoryMapper.Mapper.Map<History>(request);
            entity.MediaId = mediaId;
            await _historyRepository.DAddAsync(entity);
            return DResult.Success();
        }
    }
}
