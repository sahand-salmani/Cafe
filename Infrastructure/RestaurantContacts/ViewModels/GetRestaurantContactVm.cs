using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Infrastructure.RestaurantContacts.ViewModels
{
    public class GetRestaurantContactVm : CreateRestaurantContactVm
    {
        public int Id { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
