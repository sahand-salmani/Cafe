using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Users;
using Infrastructure.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.ViewComponents
{
    public class UserNavbarOptionsViewComponent : ViewComponent
    {
        private readonly IMediator _mediator;

        public UserNavbarOptionsViewComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = new GetCurrentUserQuery();
            var result = await _mediator.Send(user);
            return View(result);

        }
    }
}
