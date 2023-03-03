using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Common;
using Infrastructure.Interns.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Controllers
{
    public class HomeController : MyController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var query = new TestQuery();
            var result = await Mediator.Send(query);
            return View(result);
        }
    }
}
