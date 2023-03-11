using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using MediatR;

namespace Infrastructure.ContractPayments.Commands
{
    public class DeleteContractPaymentCommand : IRequest<OperationResult<Unit>>
    {
        public DeleteContractPaymentCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
