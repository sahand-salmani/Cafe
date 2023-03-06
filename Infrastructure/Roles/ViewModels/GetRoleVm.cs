using System;
using System.Collections.Generic;
using System.Text;
using Domain.Users;

namespace Infrastructure.Roles.ViewModels
{
    public class GetRoleVm
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ApplicationUserRole> Users { get; set; } = new List<ApplicationUserRole>();
    }
}
