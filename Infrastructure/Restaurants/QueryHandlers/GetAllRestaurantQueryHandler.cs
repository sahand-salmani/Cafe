﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataAccess.Database;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Restaurants.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Restaurants.QueryHandlers
{
    public class GetAllRestaurantQueryHandler : IRequestHandler<GetAllRestaurantQuery, PaginatedList<Restaurant>>
    {
        private readonly DatabaseContext _context;

        public GetAllRestaurantQueryHandler(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<Restaurant>> Handle(GetAllRestaurantQuery request, CancellationToken cancellationToken)
        {
            var restaurants = _context.Restaurants
                .AsNoTracking()
                .OrderByDescending(e => e.CreatedAt);
            var paginated = await PaginatedList<Restaurant>.CreateAsync(restaurants, request.Page, request.Size);

            return paginated;
        }
    }
}
