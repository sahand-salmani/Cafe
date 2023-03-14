using CafeTap.Controllers.Base;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Spends.Commands;
using Infrastructure.Spends.Queries;
using Infrastructure.Spends.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("panel")]
    [Route("[area]/[controller]/[action]")]
    [Authorize(Policy = "Full Spend")]
    public class SpendsController : MyController
    {
        [HttpGet]
        [Route("")]
        [Route("{page:int:min(1)}")]
        public async Task<IActionResult> Index(int page = 1)
        {
            var query = new GetAllSpendsQuery(page, 20);
            PaginatedList<Spend> result = await Mediator.Send(query);
            return View(result);
        }
        [HttpGet]

        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetSpendByIdQuery(id);
            var result = await Mediator.Send(query);

            if(result is null)
            {
                return View("Not Found");
            }

            return View(result);
        }

        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(CreateSpendVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new CreateSpendCommand(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public async Task<IActionResult> Update(int id)
        {
            var query = new GetSpendToUpdateQuery(id);
            var result = await Mediator.Send(query);
            return View(result);
        }

        [HttpPost]

        public async Task<IActionResult> Update(int id, EditSpendVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new UpdateSpendCommand(id, model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteSpendCommand(id);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
