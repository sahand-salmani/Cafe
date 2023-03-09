using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.RestaurantContacts.ViewModels
{
    public class CreateRestaurantContactDetailVm : CreateRestaurantContactVm
    {
        public int RestaurantId { get; set; }
    }
}
