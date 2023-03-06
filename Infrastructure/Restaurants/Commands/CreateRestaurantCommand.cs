using System.ComponentModel.DataAnnotations;
using Infrastructure.Common;
using MediatR;

namespace Infrastructure.Restaurants.Commands
{
    public class CreateRestaurantCommand : IRequest<OperationResult<int>>
    {
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
