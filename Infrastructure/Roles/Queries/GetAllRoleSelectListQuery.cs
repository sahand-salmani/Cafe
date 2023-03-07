using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infrastructure.Roles.Queries
{
    public class GetAllRoleSelectListQuery : IRequest<MultiSelectList>
    {
    }
}
