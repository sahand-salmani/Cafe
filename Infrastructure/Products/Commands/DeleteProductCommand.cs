using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using MediatR;

namespace Infrastructure.Products.Commands
{
    public class DeleteProductCommand : IRequest<OperationResult<Unit>>
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
