using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Users;
using Infrastructure.Common;
using Infrastructure.Roles.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Roles.CommandHandlers
{
    public class UpdateRoleClaimsCommandHandler : IRequestHandler<UpdateRoleClaimsCommand, OperationResult<string>>
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UpdateRoleClaimsCommandHandler(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<OperationResult<string>> Handle(UpdateRoleClaimsCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<string>();

            var role = await _roleManager.FindByIdAsync(request.Model.RoleId);

            if (role is null)
            {
                return result.AddError("Role was not found");
            }

            var roleClaims = await _roleManager.GetClaimsAsync(role);

            if (roleClaims.Any())
            {
                foreach (var roleClaim in roleClaims)
                {
                    await _roleManager.RemoveClaimAsync(role, roleClaim);
                }
            }

            foreach (var claim in request.Model.ClaimsValues)
            {
                if (ClaimStore.Claims.Any(e => e.Value == claim))
                {
                    var tempClaim = new Claim(claim, claim);
                    await _roleManager.AddClaimAsync(role, tempClaim);
                }
            }

            result.Entity = role.Id;

            return result;
        }
    }
}
