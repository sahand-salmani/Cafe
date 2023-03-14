using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infrastructure.Claims.Queries
{
    public class GetAllClaimsMultiSelectListQuery : IRequest<MultiSelectList>
    {
        public GetAllClaimsMultiSelectListQuery(string roleId)
        {
            RoleId = roleId;
        }
        public string RoleId { get; set; }
    }
}
