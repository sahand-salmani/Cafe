using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using Infrastructure.Roles.ViewModels;
using MediatR;

namespace Infrastructure.Roles.Commands
{
    public class UpdateRoleCommand : IRequest<OperationResult<GetRoleVm>>
    {
        public UpdateRoleCommand(UpdateRoleVm model)
        {
            Model = model;
        }
        public UpdateRoleVm Model { get; set; }
    }
}
