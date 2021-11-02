using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Error"] = "123";
            return View();
        }
    }
}
