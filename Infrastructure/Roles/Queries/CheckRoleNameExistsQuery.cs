using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MediatR;

namespace Infrastructure.Roles.Queries
{
    public class CheckRoleNameExistsQuery : IRequest<bool>
    {
        public CheckRoleNameExistsQuery(string roleName)
        {
            RoleName = roleName;
        }
        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }
    }
}
