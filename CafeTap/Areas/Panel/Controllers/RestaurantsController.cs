using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Restaurants.Commands;
using Infrastructure.Restaurants.Queries;
using Infrastructure.Restaurants.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    public class RestaurantsController : MyController
    {
        [HttpGet]
        [Route("")]
        [Route("{page:int:min(1)}")]
        public async Task<IActionResult> Index(int page=1)
        {
            var query = new GetAllRestaurantQuery(page, 20);
            return View(await Mediator.Send(query));
        }


        [HttpGet]
        [Route("")]
        [Route("{name}/{page:int:min(1)}")]
        public async Task<IActionResult> SearchByName(string name, int page = 1)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction(nameof(Index));
            }
            var query = new GetAllRestaurantSearchByNameQuery(name, page, 10);
            var result = await Mediator.Send(query);

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
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
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(CreateRestaurantInDetailsVm model)
        {
            var command = new CreateRestaurantCommand(model);
            var result = await Mediator.Send(command);

            if (result.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            ErrorHandler();
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            GetRestaurantByIdQuery query = new GetRestaurantByIdQuery(id);

            return View(await Mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, GetRestaurantVm model)
        {
            var command = new UpdateRestaurantCommand(id, model);
            var result = await Mediator.Send(command);
            if (!result.Success)
            {
                AddError(result.Errors);
                return View(result.Entity);
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteRestaurantCommand(id);
            var result = await Mediator.Send(command);

            return RedirectToAction(nameof(Index));
        }


    }
}
