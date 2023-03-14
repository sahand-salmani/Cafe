using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Domain.Common;

namespace Domain.Models
{
    public class UserRegisterToken : BaseEntity
    {
        [MaxLength(20), Required]
        public string Token { get; set; }
        public bool IsUsed { get; set; } 
    }
}
