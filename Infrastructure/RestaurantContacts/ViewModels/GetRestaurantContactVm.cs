using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Infrastructure.RestaurantContacts.ViewModels
{
    public class GetRestaurantContactVm : CreateRestaurantContactVm
    {
        public Restaurant Restaurant { get; set; }
    }
}
