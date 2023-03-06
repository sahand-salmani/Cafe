using System.ComponentModel.DataAnnotations;
using Infrastructure.Common;
using MediatR;

namespace Infrastructure.Positions.Commands
{
    public class CreatePositionCommand : IRequest<OperationResult<int>>
    {
        [MaxLength(255), Required]
        public string Name { get; set; }
    }
}
