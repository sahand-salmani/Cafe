using System.Collections.Generic;
using Domain.Models;

namespace Infrastructure.Restaurants.ViewModels
{
    public class GetRestaurantVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonInCharge { get; set; }
        public Contract Contract { get; set; }
        public List<Stant> Stants { get; set; }
    }
}
