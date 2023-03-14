using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.Identity.ViewModels
{
    public class LoginVm
    {
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        [Required, MaxLength(50), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
