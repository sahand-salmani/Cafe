using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using Infrastructure.RestaurantContacts.ViewModels;
using MediatR;

namespace Infrastructure.RestaurantContacts.Queries
{
    public class GetRestaurantContactToUpdateQuery : IRequest<GetRestaurantContactVm>
    {
        public GetRestaurantContactToUpdateQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
