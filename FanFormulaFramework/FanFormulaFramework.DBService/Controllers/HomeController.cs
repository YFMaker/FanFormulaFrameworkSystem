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
        [ViewData]
        public string Message { get; set; }

        public IActionResult Index()
        {
            string messagestring = string.Empty;
            DataBaseServiceStart(out messagestring);
            Message = "123111";
            return View();
        }


        public void DataBaseServiceStart(out string message)
        {
            message = "";
        }

    }
}
