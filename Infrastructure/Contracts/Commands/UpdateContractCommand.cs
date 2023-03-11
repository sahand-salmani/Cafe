using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using Infrastructure.Contracts.ViewModels;
using MediatR;

namespace Infrastructure.Contracts.Commands
{
    public class UpdateContractCommand : IRequest<OperationResult<int>>
    {
        public UpdateContractCommand(UpdateContractVm model)
        {
            Model = model;
        }
        public UpdateContractVm Model { get; set; }
    }
}
