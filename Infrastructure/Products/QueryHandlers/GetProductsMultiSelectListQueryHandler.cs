using System.Threading;
using System.Threading.Tasks;
using DataAccess.Database;
using Domain.Models;
using Infrastructure.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Products.QueryHandlers
{
    public class GetProductsMultiSelectListQueryHandler : IRequestHandler<GetProductsMultiSelectListQuery, MultiSelectList>
    {
        private readonly DatabaseContext _context;

        public GetProductsMultiSelectListQueryHandler(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<MultiSelectList> Handle(GetProductsMultiSelectListQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.AsNoTracking().ToListAsync(cancellationToken);

            return new MultiSelectList(products, nameof(Product.Id), nameof(Product.Name), request.Products);
        }
    }
}
