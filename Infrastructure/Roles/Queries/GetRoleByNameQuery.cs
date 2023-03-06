using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Roles.ViewModels;
using MediatR;

namespace Infrastructure.Roles.Queries
{
    public class GetRoleByNameQuery : IRequest<GetRoleVm>
    {
        public GetRoleByNameQuery(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
