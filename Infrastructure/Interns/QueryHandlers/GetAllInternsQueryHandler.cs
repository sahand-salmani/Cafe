using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataAccess.Pagination;
using Infrastructure.Interns.Queries;
using Infrastructure.Interns.ViewModels;
using MediatR;

namespace Infrastructure.Interns.QueryHandlers
{
    public class GetAllInternsQueryHandler : IRequestHandler<GetAllInternsQuery, PaginatedList<GetInternVm>>
    {
        public Task<PaginatedList<GetInternVm>> Handle(GetAllInternsQuery request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
