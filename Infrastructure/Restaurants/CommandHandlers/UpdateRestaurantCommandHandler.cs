using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Constants;
using DataAccess.Database;
using DataAccess.Persistence;
using Domain.Models;
using Infrastructure.Common;
using Infrastructure.Restaurants.Commands;
using Infrastructure.Restaurants.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Restaurants.CommandHandlers
{
    public class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand, OperationResult<GetRestaurantVm>>
    {
        private readonly DatabaseContext _context;
        private readonly IPersistence _persistence;
        private readonly IMapper _mapper;

        public UpdateRestaurantCommandHandler(DatabaseContext context,
                                              IPersistence persistence,
                                              IMapper mapper)
        {
            _context = context;
            _persistence = persistence;
            _mapper = mapper;
        }

        public async Task<OperationResult<GetRestaurantVm>> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<GetRestaurantVm>();
            var restaurant = await _context.Restaurants.AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id == request.UpdateRestaurantVm.Id, cancellationToken);

            if (restaurant is null)
            {
                return result.AddError(ErrorMessages.EntityNotFound);
            }

            var updated = _mapper.Map<Restaurant>(request.UpdateRestaurantVm);

            _context.Restaurants.Update(updated);

            var persistenceResult = await _persistence.SaveChangesAsync();

            if (persistenceResult != 0)
            {
                result.Entity = _mapper.Map<GetRestaurantVm>(updated);
                return result;
            }

            return result.AddError(ErrorMessages.)

        }
    }
}
