using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.Interns.ViewModels
{
    public class CreateInternVm
    {
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [MaxLength(255)]
        public string Position { get; set; }
        [MaxLength(255)]
        public string University { get; set; }
        [MaxLength(255)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartsAt { get; set; }
        public DateTime FinishedAt { get; set; }
    }
}
