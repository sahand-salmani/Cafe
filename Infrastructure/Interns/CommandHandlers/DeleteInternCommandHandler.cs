using System.Threading;
using System.Threading.Tasks;
using DataAccess.Constants;
using DataAccess.Database;
using DataAccess.Persistence;
using Infrastructure.Common;
using Infrastructure.Interns.Commands;
using MediatR;

namespace Infrastructure.Interns.CommandHandlers
{
    public class DeleteInternCommandHandler : IRequestHandler<DeleteInternCommand,OperationResult<Unit>>
    {
        private readonly IEntity _entity;
        private readonly IPersistence _persistence;

        public DeleteInternCommandHandler(IEntity entity,
                                          IPersistence persistence)
        {
            _entity = entity;
            _persistence = persistence;
        }
        public async Task<OperationResult<Unit>> Handle(DeleteInternCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Unit>();

            var intern = await _entity.Interns.FindAsync(request.Id, cancellationToken);

            if (intern is null)
            {
                return result.AddError(ErrorMessages.EntityNotFound);
            }

            _entity.Interns.Remove(intern);
            var persistenceResult = await _persistence.SaveChangesAsync();

            if (persistenceResult == 0)
            {
                return result.AddError(ErrorMessages.CouldNotDelete);
            }

            return result;
        }
    }
}
