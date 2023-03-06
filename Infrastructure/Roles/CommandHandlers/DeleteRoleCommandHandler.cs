using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Constants;
using DataAccess.Database;
using DataAccess.Persistence;
using Domain.Users;
using Infrastructure.Common;
using Infrastructure.Roles.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Roles.CommandHandlers
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, OperationResult<Unit>>
    {
        private readonly DatabaseContext _context;
        private readonly IPersistence _persistence;

        public DeleteRoleCommandHandler(DatabaseContext context,
                                        IPersistence persistence)
        {
            _context = context;
            _persistence = persistence;
        }
        public async Task<OperationResult<Unit>> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Unit>();

            var role = await _context.Roles.Include(e => e.Users)
                .SingleOrDefaultAsync(e => e.Name == request.Name, cancellationToken);

            if (role.Users.Any())
            {
                return result.AddError("Could not delete role that has user associated with it");
            }

            _context.Roles.Remove(role);

            var persistenceResult = await _persistence.SaveChangesAsync();

            if (persistenceResult == 0)
            {
                return result.AddError(ErrorMessages.CouldNotDelete);
            }

            result.Entity = Unit.Value;
            return result;
        }
    }
}
