using FanFormulaFramework.Public;
using FanFormulaFramework.Service.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FanFormulaFramework.Service.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoger<HomeController> loger;
        private IHttpClientFactory _httpClient;

        public HomeController(IHttpClientFactory httpClient)
        {
            this.loger = new ILoger<HomeController>();
            this._httpClient = httpClient;
        }

        /// <summary>
        /// 标题
        /// </summary>
        [ViewData]
        public string Title { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [ViewData]
        public string HeadTitel { get; set; }


        public IActionResult Index()
        {
            Title = "后台管理中心登录";
            HeadTitel = "后台管理中心";
            return View();
        }



        public IActionResult Logon(LogOnModel logOnModel)
        {
            return View();
        }







        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
