using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.RestaurantContacts.ViewModels
{
    public class UpdateRestaurantContactVm
    {
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Position { get; set; }
        [MaxLength(255)]
        public string PhoneNumber { get; set; }
        public int RestaurantId { get; set; }
    }
}
