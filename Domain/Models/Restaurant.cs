using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Models
{
    public class Restaurant : BaseEntity
    {
        [Required, MaxLength(1080)]
        public string Address { get; set; }
        [Required, MaxLength(55), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [MaxLength(255)]
        public string PersonInCharge { get; set; }
        public Contract Contract { get; set; }
        public ICollection<Stant> Stants { get; set; }
    }
}
