using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using Infrastructure.Roles.ViewModels;
using MediatR;

namespace Infrastructure.Roles.Commands
{
    public class UpdateRoleClaimsCommand : IRequest<OperationResult<string>>
    {
        public UpdateRoleClaimsCommand(RoleClaimsVm model)
        {
            Model = model;
        }
        public RoleClaimsVm Model { get; set; }
    }
}
