using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Restaurants.ViewModels
{
    public class UpdateRestaurantVm
    {
        public int Id { get; set; }
        [Required, MaxLength(1080)]
        public string Address { get; set; }
        [Required, MaxLength(55), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [MaxLength(255)]
        public string PersonInCharge { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }
    }
}
