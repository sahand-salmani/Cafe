using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Users.ViewModels;
using MediatR;

namespace Infrastructure.Users.Queries
{
    public class GetCurrentUserQuery : IRequest<GetUserVm>
    {
    }
}
