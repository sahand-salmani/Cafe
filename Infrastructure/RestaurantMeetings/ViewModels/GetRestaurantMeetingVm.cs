using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Domain.Models;

namespace Infrastructure.RestaurantMeetings.ViewModels
{
    public class GetRestaurantMeetingVm
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Person { get; set; }
        public string Note { get; set; }
        public Restaurant Restaurant { get; set; }
        [DataType(DataType.DateTime), Required]
        public DateTime HappensAt { get; set; }
    }
}
