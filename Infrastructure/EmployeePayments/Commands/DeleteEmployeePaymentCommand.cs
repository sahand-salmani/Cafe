using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using MediatR;

namespace Infrastructure.EmployeePayments.Commands
{
    public class DeleteEmployeePaymentCommand : IRequest<OperationResult<Unit>>
    {
        public DeleteEmployeePaymentCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
