using FanFormulaFramework.DBService.Models;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Http;
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
            Result result = new Result();
            try
            {
                QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {

                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    result.data = "未获取准确业务项目";
                }
                return result;
            }
            catch (Exception ex)
            {
                loger.Error(ex.Message);

                result.code = 0;
                result.message = "失败";
                result.data = ex.Message;
                return result;
            }
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
