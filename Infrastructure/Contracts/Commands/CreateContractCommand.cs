using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using Infrastructure.Contracts.ViewModels;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infrastructure.Contracts.Commands
{
    class CreateContractCommand : IRequest<OperationResult<int>>
    {
        public CreateContractCommand(CreateContractVm model)
        {
            Model = model;
        }

        public CreateContractVm Model { get; set; }
    }
}
