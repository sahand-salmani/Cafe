using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Database;
using Infrastructure.RestaurantContacts.Queries;
using Infrastructure.RestaurantContacts.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.RestaurantContacts.QueriesHandlers
{
    public class GetRestaurantContactToUpdateQueryHandler : IRequestHandler<GetRestaurantContactToUpdateQuery, GetRestaurantContactVm>
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public GetRestaurantContactToUpdateQueryHandler(DatabaseContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetRestaurantContactVm> Handle(GetRestaurantContactToUpdateQuery request, CancellationToken cancellationToken)
        {
            var result = new GetRestaurantContactVm();

            var restaurantContact = await _context.RestaurantContacts.Include(r => r.Restaurant)
                .SingleOrDefaultAsync(r => r.Id == request.Id,cancellationToken);
            if (restaurantContact is null)
            {
                return null;
            }

            return _mapper.Map<GetRestaurantContactVm>(restaurantContact);
        }
    }
}
