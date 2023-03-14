using DataAccess.Database;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Spends.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Spends.QueryHandlers
{
    class GetAllSpendsQueryHandler : IRequestHandler<GetAllSpendsQuery, PaginatedList<Spend>>
    {
        private readonly DatabaseContext _context;

        public GetAllSpendsQueryHandler(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<Spend>> Handle(GetAllSpendsQuery request, CancellationToken cancellationToken)
        {
            var spends = _context.Spends.AsNoTracking().OrderByDescending(s => s.CreatedAt);
            return await PaginatedList<Spend>.CreateAsync(spends, request.Page, request.Size);
        }
    }
}
