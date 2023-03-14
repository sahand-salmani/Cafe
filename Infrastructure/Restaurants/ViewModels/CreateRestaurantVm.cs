using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Restaurants.ViewModels
{
    public class CreateRestaurantVm
    {
        [MaxLength(255), Required]

        public string Name { get; set; }
        [Required, MaxLength(1080)]
        public string Address { get; set; }
        [Required, MaxLength(55), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [MaxLength(255), Required]
        public string City { get; set; }
    }
}
