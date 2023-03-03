using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using MediatR;

namespace Infrastructure.Interns.Commands
{
    public class DeleteInternCommand : IRequest<OperationResult<Unit>>
    {
        public int Id { get; set; }

        private DeleteInternCommand(int id)
        {
            Id = id;
        }

        public static DeleteInternCommand Delete(int id) => new DeleteInternCommand(id);
    }
}
