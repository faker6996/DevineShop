using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.AccountHandler.Commands.Delete
{
    public class DeleteAccountCommand : IRequest<Respond>
    {
        public string AccountId { get; set; }
    }

    public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand, Respond>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteAccountCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
        {
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Id == request.AccountId);

            if (account == null) throw new AppException("Tài khoản không tồn tại");

            await _unitOfWork.Accounts.DDeleteAsync(account);


            var accountBlogPosts = _unitOfWork.AccountBlogPosts.DGet(a => a.AccountId == request.AccountId);
            foreach (var accountBlogPost in accountBlogPosts)
            {
                await _unitOfWork.AccountBlogPosts.DDeleteAsync(accountBlogPost);
            }

            var comments = _unitOfWork.Comments.DGet(a => a.AccountId == request?.AccountId);
            foreach (var comment in comments)
            {
                await _unitOfWork.Comments.DDeleteAsync(comment);
            }

            await _unitOfWork.SaveAsync();

            return Respond.Success();
        }
    }
}
