using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService.Controllers
{
    [ApiController]
    [Route("db/[action]")]
    public class PerformController : Controller
    {
        private static ILoger<PerformController> loger;

        public PerformController()
        {
            loger = new ILoger<PerformController>();
        }


        /// <summary>
        /// 增加接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Insert()
        {
            return Json("ddd");
        }

        /// <summary>
        /// 删除接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Delete()
        {
            return Json("dddd");
        }

        /// <summary>
        /// 更改接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Update()
        {
            return Json("ddd");
        }

        /// <summary>
        /// 查询接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Select()
        {
            return Json("ddd");
        }

    }
}
