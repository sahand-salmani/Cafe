using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Roles.ViewModels;
using MediatR;

namespace Infrastructure.Roles.Queries
{
    public class GetAllRolesQuery : IRequest<List<GetRoleVm>>
    {
    }
}
