using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Products.CommandHandlers;
using Infrastructure.Products.Commands;
using Infrastructure.Products.Queries;
using Infrastructure.Products.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    public class ProductsController : MyController
    {

        [HttpGet]
        [Route("")]
        [Route("{page:int:min(1)}")]
        public async Task<IActionResult> Index(int page = 1)
        {
            var query = new GetAllProductsQuery(page, 20);
            PaginatedList<Product> result = await Mediator.Send(query);

            return View(result);

        }


        [HttpGet]
        [Route("")]
        [Route("{name}/{page:int:min(1)}")]
        public async Task<IActionResult> SearchByName(string name, int page = 1)
        {
            var query = new GetProductsSearchByNameQuery(name, page, 10);
            return View(await Mediator.Send(query));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            var result = await Mediator.Send(command);
            if (!result.Success)
            {
                AddError(result.Errors);
                return View(command);
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var query = new GetProductToUpdateQuery(id);
            var result = await Mediator.Send(query);

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateProductVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new UpdateProductCommand(id, model);
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
            var command = new DeleteProductCommand(id);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                //Handler Later
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
