using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Constants;
using DataAccess.Database;
using DataAccess.Persistence;
using Domain.Models;
using Infrastructure.Common;
using Infrastructure.Interns.Commands;
using MediatR;

namespace Infrastructure.Restaurants.CommandHandlers
{
    public class CreateRestaurantCommandHandler : IRequestHandler<CreateInternCommand, OperationResult<int>>
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IPersistence _persistence;

        public CreateRestaurantCommandHandler(DatabaseContext context,
                                              IMapper mapper,
                                              IPersistence persistence)
        {
            _context = context;
            _mapper = mapper;
            _persistence = persistence;
        }
        public async Task<OperationResult<int>> Handle(CreateInternCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<int>();

            var restaurant = _mapper.Map<Restaurant>(request);

            await _context.Restaurants.AddAsync(restaurant, cancellationToken);

            var persistence = await _persistence.SaveChangesAsync();

            if (persistence == 0) return result.AddError(ErrorMessages.CouldNotAddToDatabase);
            result.Entity = restaurant.Id;
            return result;

        }
    }
}
