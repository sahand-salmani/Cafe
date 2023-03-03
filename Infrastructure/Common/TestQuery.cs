using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Common
{
    public class TestQuery : IRequest<Unit>
    {
    }

    public class TestQueryHandler : IRequestHandler<TestQuery, Unit>
    {
        private readonly DatabaseContext _context;

        public TestQueryHandler(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(TestQuery request, CancellationToken cancellationToken)
        {
            var a = await _context.Interns.ToListAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
