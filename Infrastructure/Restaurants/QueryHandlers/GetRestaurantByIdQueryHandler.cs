using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Database;
using Infrastructure.Restaurants.Queries;
using Infrastructure.Restaurants.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Restaurants.QueryHandlers
{
    public class GetRestaurantByIdQueryHandler : IRequestHandler<GetRestaurantByIdQuery, GetRestaurantVm>
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public GetRestaurantByIdQueryHandler(DatabaseContext context,
                                             IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetRestaurantVm> Handle(GetRestaurantByIdQuery request, CancellationToken cancellationToken)
        {
            var restaurant = await _context.Restaurants
                .AsNoTracking()
                .Include(e => e.Contract)
                .ThenInclude(e => e.Employee)
                .Include(e => e.Contract)
                .ThenInclude(e => e.ContractPayments)
                .Include(e => e.Stants)
                .Include(e => e.RestaurantMeetings)
                .Include(e => e.RestaurantContacts)
                .SingleOrDefaultAsync(e => e.Id == request.Id, cancellationToken);

            if (restaurant is null)
            {
                return null;
            }

            return _mapper.Map<GetRestaurantVm>(restaurant);
        }
    }
}
