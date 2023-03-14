using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeTap.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace CafeTap.Areas.Identity.Controllers
{
    public class RegisterController : MyController
    {

        [HttpGet]
        public IActionResult Register() => View();
    }
}
