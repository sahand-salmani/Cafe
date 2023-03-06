using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain.Users
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> Users { get; set; }
    }
}
