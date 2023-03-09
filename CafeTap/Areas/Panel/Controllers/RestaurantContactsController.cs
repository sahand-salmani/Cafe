using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.RestaurantContacts.Commands;
using Infrastructure.RestaurantContacts.ViewModels;
using Infrastructure.Restaurants.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("panel")]
    public class RestaurantContactsController : MyController
    {
        [HttpGet]
        public IActionResult Add(int id)
        {
            var model = new CreateRestaurantContactDetailVm
            {
                RestaurantId = id
            };


            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(CreateRestaurantContactDetailVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new CreateRestaurantContactCommand(model);
            var result = await Mediator.Send(command);
            if (!result.Success)
            {
                AddError(result.Errors);
            }

            return RedirectToAction("Index", "Restaurants");
        }
    }
}
