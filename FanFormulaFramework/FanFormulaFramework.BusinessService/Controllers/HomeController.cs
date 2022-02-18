using FanFormulaFramework.BusinessService.Models;
using FanFormulaFramework.BusinessService.Until;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoger<HomeController> loger;
        private IHttpClientFactory _httpClient;

        public HomeController(IHttpClientFactory httpClient)
        {
            this.loger = new ILoger<HomeController>();
            this._httpClient = httpClient;
            this.InterFaces = new InterFaceStateList();
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
        /// <summary>
        /// 其他信息
        /// </summary>
        [ViewData]
        public string TitleOther { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        [ViewData]
        public string Message { get; set; }


        public IActionResult Index()
        {
            TitleName = "接口状态";
            TitleOther = "各接口信息为实时验证结果。";
            SelectIntaceFaceState();
            Message = "接口检测结果";
            return View();
        }

        public IActionResult EditInterFace(InterfaceState interfaceState)
        {
            int businesskey = interfaceState.Businesskey;
            string statetype = interfaceState.InterFaceStated == true ? "CloseDB" : "StartDB";
            

            TitleName = "接口状态";
            TitleOther = "各接口信息为实时验证结果。";
            SelectIntaceFaceState();
            Message = "接口检测结果";
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

        /// <summary>
        /// 查询接口状态
        /// </summary>
        public void SelectIntaceFaceState()
        {
            //InterFaces.interfaceStates.Clear();
            for (int typecode = 0; typecode < 5; typecode++)
            {
                InterfaceState interfacestate = new InterfaceState();
                string postState = PostUntil.PostPush("select", typecode, "select 1");
                interfacestate.Businesskey = typecode;
                PostResultModel postmodel = PostUntil.JsonToObject<PostResultModel>(postState);
                if (postmodel.code == 1)
                {
                    interfacestate.InterFaceName = Enum.GetName(typeof(RequestBusinessType), typecode);
                    interfacestate.InterFaceStated = true;
                    interfacestate.Remarke = postmodel.message;
                }
                else
                {
                    interfacestate.InterFaceName = Enum.GetName(typeof(RequestBusinessType), typecode);
                    interfacestate.InterFaceStated = false;
                    interfacestate.Remarke = postmodel.message;
                }
                InterFaces.interfaceStates.Add(interfacestate);
            }

        }

        /// <summary>
        /// 调整接口状态
        /// </summary>
        /// <param name="businesskey"></param>
        /// <param name="statetype"></param>
        /// <returns></returns>
        public bool SetIntaceFaceState(int businesskey, string statetype)
        {
            string getState = PostUntil.GetPush(businesskey, statetype);
            PostResultModel getmodel = PostUntil.JsonToObject<PostResultModel>(getState);
            if (getmodel.code == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
