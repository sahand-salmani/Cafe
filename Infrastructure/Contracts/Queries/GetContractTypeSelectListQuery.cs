using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infrastructure.Contracts.Queries
{
    public class GetContractTypeSelectListQuery : IRequest<SelectList>
    {
    }
}
