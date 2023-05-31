using MARShop.Application.Mapper;
using MARShop.Application.Models;
using MARShop.Core.Entities;
using MARShop.Core.Enum;
using MARShop.Infastructure.Repositories.AccountRepository;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.AccountHandler.Commands.CreateAccount
{
    public class CreateAccountCommand : IRequest<DResult>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, DResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateAccountCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<DResult> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var entity = AccountMapper.Mapper.Map<Account>(request);
            entity.Role = (int)RoleEnum.Admin;
            if (entity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            await _unitOfWork.Accounts.DAddAsync(entity);
            await _unitOfWork.Save();
            return DResult.Success();
        }
    }
}
