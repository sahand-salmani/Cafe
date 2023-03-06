using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Employees.Commands;
using Infrastructure.Employees.Queries;
using Infrastructure.Employees.ViewModels;
using Infrastructure.Interns.Queries;
using Infrastructure.Positions.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    public class EmployeesController : MyController
    {
        [HttpGet]
        [Route("")]
        [Route("{page:int:min(1)}")]
        public async Task<IActionResult> Index(int page = 1)
        {
            var query = new GetAllEmployeesQuery(page, 20);
            var result = await Mediator.Send(query);
            return View(result);
        }


        [HttpGet("{id:int:min(1)}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetEmployeeByIdQuery(id);
            var result = await Mediator.Send(query);
            if (result is null)
            {
                //TODO: ADD LATER
                return View("NotFound");
            }
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CreateEmployeeVm();
            var selectListQuery = new GetAllPositionSelectListQuery(0);
            var selectListResult = await Mediator.Send(selectListQuery);
            model.SelectList = selectListResult;
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(CreateEmployeeVm model)
        {
            if (!ModelState.IsValid)
            {
                var selectListQuery = new GetAllPositionSelectListQuery(model.PositionId);
                var selectListResult = await Mediator.Send(selectListQuery);
                model.SelectList = selectListResult;
                return View(model);
            }

            var command = new CreateEmployeeCommand(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
