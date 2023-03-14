using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Users.ViewModels
{
    public class GetUserVm
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public List<UserRoleVm> UserRoles { get; set; }
    }
}
