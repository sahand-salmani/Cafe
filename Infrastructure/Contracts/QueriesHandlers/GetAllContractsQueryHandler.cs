using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataAccess.Database;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Contracts.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contracts.QueriesHandlers
{
    public class GetAllContractsQueryHandler : IRequestHandler<GetAllContractsQuery, PaginatedList<Contract>>
    {
        private readonly DatabaseContext _context;

        public GetAllContractsQueryHandler(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<Contract>> Handle(GetAllContractsQuery request, CancellationToken cancellationToken)
        {
            var contracts = _context.Contracts.Include(e => e.Employee).Include(e => e.Restaurant).AsNoTracking()
                .OrderByDescending(e => e.CreatedAt);

            return await PaginatedList<Contract>.CreateAsync(contracts, request.Page, request.Size);
        }
    }
}
