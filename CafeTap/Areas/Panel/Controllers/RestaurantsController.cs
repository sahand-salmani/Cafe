using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Restaurants.Commands;
using Infrastructure.Restaurants.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class RestaurantsController : MyController
    {
        [HttpGet]
        public async Task<IActionResult> Index(int page, int size)
        {
            var query = new GetAllRestaurantQuery(page, size);
            return View(await Mediator.Send(query));
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetRestaurantByIdQuery(id);

            var result = await Mediator.Send(query);

            if (result is null)
            {
                return View("NotFound");
            }

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateRestaurantCommand command)
        {
            var result = await Mediator.Send(command);

            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            ErrorHandler();
            return View(command);
        }



    }
}
