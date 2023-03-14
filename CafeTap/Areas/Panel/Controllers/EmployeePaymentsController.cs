using CafeTap.Controllers.Base;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.EmployeePayments.Commands;
using Infrastructure.EmployeePayments.Queries;
using Infrastructure.EmployeePayments.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("panel")]
    [Route("[area]/[controller]/[action]")]
    public class EmployeePaymentsController : MyController
    {
        [HttpGet]
        [Route("")]
        [Route("{page:int:min(1)}")]
        public async Task<IActionResult> Index(int page = 1)
        {
            var query = new GetAllEmployeePaymentsQuery(1, 20);
            PaginatedList<EmployeePayment> result = await Mediator.Send(query);
            return View(result);
        }

        [HttpGet]
        [Route("")]
        [Route("{id:int:min(1)}/{page:int:min(1)}")]
        public async Task<IActionResult> EmployeePayments(int id, int page=1)
        {
            var query = new GetPaymentsOfEmployeeQuery(id, page, 10);
            return View(await Mediator.Send(query));
        }




        [HttpGet]
        public IActionResult Add(int id)
        {
            var model = new CreateEmployeePaymentVm()
            {
                EmployeeId = id,
            };
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(CreateEmployeePaymentVm model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            var command = new CreateEmployeePaymentCommand(model);

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
            var query = new GetEmployeePaymentToUpdateQuery(id);
            var result = await Mediator.Send(query);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateEmployeePaymentVm model)
        {
            var command = new UpdateEmployeePaymentCommand(model, id);

            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                result.AddError(result.Errors);
                return View(model);
            }


            // change to employee payments
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteEmployeePaymentCommand(id);
            var result = await Mediator.Send(command);

            if (!result.Success)
            {
                AddError(result.Errors);
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }


    }
}
