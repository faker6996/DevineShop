using MARShop.Application.Models;
using MARShop.Application.Share;
using MARShop.Infastructure.Repositories.HistoryRepository;
using MARShop.Infastructure.Repositories.MediaRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.MediaHandler.Commands.DeleteMedia
{
    public class DeleteMediaCommand : IRequest<DResult>
    {
        public int Id { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public DeleteMediaCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteMediaCommandHandler : IRequestHandler<DeleteMediaCommand, DResult>
    {
        private readonly IMediaRepository _mediaRepository;
        private readonly IHistoryRepository _historyRepository;

        public DeleteMediaCommandHandler(IMediaRepository mediaRepository, IHistoryRepository historyRepository)
        {
            _mediaRepository = mediaRepository;
            _historyRepository = historyRepository;
        }

        public async Task<DResult> Handle(DeleteMediaCommand request, CancellationToken cancellationToken)
        {
            var entity = await _mediaRepository.DGetByIdAsync(request.Id);
            var vWSGet = new VWSDelete()
            {
                IdTarget = entity.ImageIdentityIdInVuforia,
                AccessKey = request.AccessKey,
                SecretKey = request.SecretKey,
            };
            DVuforia.DeleteNow(vWSGet);

            await _mediaRepository.DeleteByIdAsync(request.Id);

            var historiesHaveMediaDelete = await _historyRepository.DGetAllAsync();
            foreach (var historyHaveMediaDelete in historiesHaveMediaDelete)
            {
                if (historyHaveMediaDelete.MediaId == request.Id)
                {
                    await _historyRepository.DeleteByIdAsync(historyHaveMediaDelete.Id);
                }
            }

            return DResult.Success();
        }
    }
}
