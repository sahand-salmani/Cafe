using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Domain.Users
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> Roles { get; set; }
    }
}
