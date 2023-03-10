using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Panel.Controllers
{
    [Area("Panel")]
    [Route("[area]/[controller]/[action]")]
    [AllowAnonymous]
    public class DashboardController : MyController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
