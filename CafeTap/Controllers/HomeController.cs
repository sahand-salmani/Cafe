using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Infrastructure.Common;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Controllers
{
    public class HomeController : MyController
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
    }
}
