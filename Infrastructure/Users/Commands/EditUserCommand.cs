using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using Infrastructure.Users.ViewModels;
using MediatR;

namespace Infrastructure.Users.Commands
{
    public class EditUserCommand : IRequest<OperationResult<string>>
    {
        public EditUserCommand(EditUserVm model)
        {
            Model = model;
        }
        public EditUserVm Model { get; set; }
    }
}
