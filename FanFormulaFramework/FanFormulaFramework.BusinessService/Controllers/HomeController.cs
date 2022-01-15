using FanFormulaFramework.BusinessService.Models;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Controllers
{
    public class HomeController : Controller
    {

        private static readonly ILoger<HomeController> loger;

        static HomeController()
        {
            loger = new ILoger<HomeController>();
        }

        /// <summary>
        /// 展示数据
        /// </summary>
        [ViewData]
        public InterFaceStateList InterFaces { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [ViewData]
        public string TitleName { get; set; }


        public IActionResult Index()
        {
            TitleName = "接口状态";
            SelectIntaceFaceState();
            return View();
        }

        /// <summary>
        /// 查询接口状态
        /// </summary>
        public void SelectIntaceFaceState()
        {

        }
    }
}
