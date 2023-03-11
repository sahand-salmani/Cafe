using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Domain.Models;

namespace Infrastructure.RestaurantMeetings.ViewModels
{
    public class CreateRestaurantMeetingVm
    {
        [Required, MaxLength(255)]
        public string Subject { get; set; }
        [MaxLength(255)]
        public string Person { get; set; }
        [MaxLength(4000)]
        public string Note { get; set; }
        public int RestaurantId { get; set; }

        [DataType(DataType.DateTime), Required]
        public DateTime HappensAt { get; set; } = DateTime.Now;
    }
}
