using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
            string messagestring = string.Empty;
            DataBaseServiceStart(out messagestring);
            ViewData["Error"] = "123111";
            return View();
        }


        public void DataBaseServiceStart(out string message)
        {
            message = "";
        }

    }
}
