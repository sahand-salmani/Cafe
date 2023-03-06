using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Roles.Commands;
using Infrastructure.Roles.Queries;
using Infrastructure.Roles.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class RoleManagementController : MyController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var query = new GetAllRolesQuery();
            var model = await Mediator.Send(query);
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRoleVm model)
        {
            var command = new AddNewRoleCommand(model);
            var result = await Mediator.Send(command);


            if (result.Success) return RedirectToAction(nameof(Index));


            foreach (var error in result.Errors)
            {
                AddError(error);
            }

            return View(model);

        }


        [HttpGet]
        public async Task<IActionResult> Edit(string roleName)
        {
            if (string.IsNullOrEmpty(roleName))
            {
                return RedirectToAction(nameof(Index));
            }

            var query = new GetRoleToUpdateQuery(roleName);
            var model = await Mediator.Send(query);
            return model == null ? View("NotFound") : View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateRoleVm model)
        {
            var command = new UpdateRoleCommand(model);
            var result = await Mediator.Send(command);
            if (!result.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> Delete(string name)
        {
            var command = new DeleteRoleCommand(name);
            var result = await Mediator.Send(command);
            if (!result.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }


        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> CheckRoleNameExists(string roleName)
        {
            var query = new CheckRoleNameExistsQuery(roleName);
            var result = await Mediator.Send(query);

            return result ? Json($"Role name {roleName} already exists") : Json(true);
        }
    }
}
