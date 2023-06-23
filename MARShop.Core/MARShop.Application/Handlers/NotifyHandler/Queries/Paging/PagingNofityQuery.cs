using MARShop.Application.Common;
using MARShop.Application.Handlers.BlogPostHandler.Queries.Get;
using MARShop.Application.Mapper;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MARShop.Application.Handlers.NotifyHandler.Queries.Paging
{
    public class PagingNofityQuery : IRequest<Respond<NotifyPaging>>
    {
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
    }
    public class NotifyRespond
    {
        public DateTime Created { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public bool IsRead { get; set; }
    }

    public class NotifyPaging : Paging<NotifyRespond>
    {
        public int TotalUnreaded { get; set; }
    }

    public class PagingNofityQueryHandler : IRequestHandler<PagingNofityQuery, Respond<NotifyPaging>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public PagingNofityQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Respond<NotifyPaging>> Handle(PagingNofityQuery request, CancellationToken cancellationToken)
        {
            var notifies = _unitOfWork.Notifies.DGetAll().OrderByDescending(a=>a.Created).Skip(request.PerPage * (request.CurrentPage - 1)).Take(request.PerPage).ToList();
            var notifiesRespond = NotifyMapper.Mapper.Map<List<NotifyRespond>>(notifies);

            var total = _unitOfWork.Notifies.DGetAll().Count();
            var totalUnread = _unitOfWork.Notifies.DGet(a=>a.IsRead == false).Count();

            var paging = new NotifyPaging()
            {
                Total = total,
                PerPage = request.PerPage,
                CurrentPage = request.CurrentPage,
                TotalUnreaded = totalUnread,
                Items = notifiesRespond
            };
            return Respond<NotifyPaging>.Success(paging);
        }
    }
}
