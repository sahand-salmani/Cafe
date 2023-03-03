using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Interns.Commands;
using Infrastructure.Interns.Queries;
using Infrastructure.Interns.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class InternsController : MyController
    {
        public async Task<IActionResult> Index()
        {
            var query = GetAllInternsQuery.GetAll(1, 1);
            return View(await Mediator.Send(query));
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
            var query = UpdateInternCommand.Update(id, model);
            return View(await Mediator.Send(query));
        }


        [HttpDelete]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            return null;
        }


        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetInternByIdQuery(id);
            var result = await Mediator.Send(query);
            return View(result);
        }

    }
}
