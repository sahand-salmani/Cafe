using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Models
{
    public class Restaurant : BaseEntity
    {
        [MaxLength(255), Required]
        public string Name { get; set; }
        [Required, MaxLength(1080)]
        public string Address { get; set; }
        [Required, MaxLength(55), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [MaxLength(255)]
        public string PersonInCharge { get; set; }
        public ICollection<Contract> Contract { get; set; }
        [MaxLength(255), Required]
        public string City { get; set; }
        public ICollection<Stant> Stants { get; set; }
    }
}
