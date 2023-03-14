using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Infrastructure.Identity.Commands
{
    public class SignOutCommand : IRequest<Unit>
    {
    }
}
