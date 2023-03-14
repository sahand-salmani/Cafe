using Infrastructure.Common;
using Infrastructure.EmployeePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EmployeePayments.Commands
{
    public class CreateEmployeePaymentCommand : IRequest<OperationResult<int>>
    {
        public CreateEmployeePaymentCommand(CreateEmployeePaymentVm model)
        {
            Model = model;
        }
        public CreateEmployeePaymentVm Model { get; set; }
     
    }
}
