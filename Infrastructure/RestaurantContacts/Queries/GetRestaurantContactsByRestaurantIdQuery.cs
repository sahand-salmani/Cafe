using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.RestaurantContacts.ViewModels;
using MediatR;

namespace Infrastructure.RestaurantContacts.Queries
{
    public class GetRestaurantContactsByRestaurantIdQuery : IRequest<List<GetRestaurantContactVm>>
    {
        public GetRestaurantContactsByRestaurantIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
