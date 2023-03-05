﻿using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Common;
using Infrastructure.Interns.Commands;
using Infrastructure.Interns.Queries;
using Infrastructure.Interns.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    public class InternsController : MyController
    {

        [Route("{page?}/{size?}")]
        public async Task<IActionResult> Index(int page, int size = 10)
        {
            var query = new GetAllInternsQuery(page, size);
            PaginatedList<Intern> result = await Mediator.Send(query);
            return View(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            var query = new GetInternByIdQuery(id);
            var result = await Mediator.Send(query);
            if (result is null)
            {
                //TODO: ADD LATER
                return View("NotFound");
            }
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateInternCommand model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await Mediator.Send(model);
            if (!result.Success)
            {
                ErrorHandler();
                return View(model);
            }

            return RedirectToAction(nameof(Add));
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var query = GetInternByIdQuery.Get(id);
            return View(await Mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id,GetInternVm model)
        {
            var command = UpdateInternCommand.Update(id, model);
            OperationResult<GetInternVm> result = await Mediator.Send(command);
            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            ErrorHandler();
            return View(command.GetInternVm);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteInternCommand(id);
            var result = await Mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }




    }
}