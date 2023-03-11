using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Contracts.Commands;
using Infrastructure.Contracts.Queries;
using Infrastructure.Contracts.ViewModels;
using Infrastructure.Employees.Queries;
using Infrastructure.Products.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    public class ContractsController : MyController
    {

        [HttpGet]
        public async Task<IActionResult> Add(int id)
        {
            var model = new CreateContractVm
            {
                RestaurantId = id
            };

            var empQuery = new GetEmployeeSelectListQuery(0);
            SelectList empSelectList = await Mediator.Send(empQuery);

            var prodQuery = new GetProductsMultiSelectListQuery(null);
            var prodMultiSelectList = await Mediator.Send(prodQuery);

            model.Employees = empSelectList;
            model.Products = prodMultiSelectList;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateContractVm model)
        {
            var empQuery = new GetEmployeeSelectListQuery(model.EmployeeId);
            SelectList empSelectList = await Mediator.Send(empQuery);

            var prodQuery = new GetProductsMultiSelectListQuery(model.ProductsId);
            var prodMultiSelectList = await Mediator.Send(prodQuery);

            model.Employees = empSelectList;
            model.Products = prodMultiSelectList;


            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new CreateContractCommand(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction("Index", "Restaurants");
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            //TODO: HANDLE GET PAGE
            var query = new GetContractByIdQuery(id);
            var result = await Mediator.Send(query);
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var query = new GetContractToUpdateQuery(id);
            var model = await Mediator.Send(query);

            var empQuery = new GetEmployeeSelectListQuery(model.EmployeeId);
            SelectList empSelectList = await Mediator.Send(empQuery);

            var prodQuery = new GetProductsMultiSelectListQuery(id);
            var prodMultiSelectList = await Mediator.Send(prodQuery);

            model.Employees = empSelectList;
            model.Products = prodMultiSelectList;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateContractVm model)
        {
            var empQuery = new GetEmployeeSelectListQuery(model.EmployeeId);
            SelectList empSelectList = await Mediator.Send(empQuery);

            var prodQuery = new GetProductsMultiSelectListQuery(model.ProductsId);
            var prodMultiSelectList = await Mediator.Send(prodQuery);
            model.Employees = empSelectList;
            model.Products = prodMultiSelectList;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var command = new UpdateContractCommand(model);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return View(model);
            }

            return RedirectToAction("Index", "Restaurants");

        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteContractCommand(id);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                return RedirectToAction("Index", "Restaurants");
            }

            return RedirectToAction("Index", "Restaurants");
        }
    }
}
