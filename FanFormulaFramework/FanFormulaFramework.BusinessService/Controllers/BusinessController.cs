using FanFormulaFramework.BusinessService.Authorized;
using FanFormulaFramework.BusinessService.Models;
using FanFormulaFramework.BusinessService.Until;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Controllers
{
    [ApiController]
    [Route("operation/[action]")]
    [BasicAuth]
    public class BusinessController : Controller
    {

        private static ILoger<BusinessController> loger;
        private static LogBase logBase;

        public BusinessController()
        {
            loger = new ILoger<BusinessController>();
        }


        [HttpPost]
        public ActionResult<object> ExecutionBusiness()
        {
            Result result = new Result();
            logBase = new LogBase();
            try
            {
                IFormCollection context = HttpContext.Request.Form;
                //QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                string businessname = context["businessname"].ToString();
                int businesskey = OperationBaseUtil.GetInterface(businessname);
                if (businesskey >= 0)
                {
                    string content = context["content"].ToString();
                    string performtype = context["performtype"].ToString();
                    logBase.BehaviorType = businessname;
                    logBase.ExecutionTime = DateTimeUtil.TOString("yyyy-MM-dd HH:mm:ss");
                    logBase.PerformContent = content;
                    string postState = PostUntil.PostPush(businesskey, performtype, content);
                    PostResultModel postmodel = PostUntil.JsonToObject<PostResultModel>(postState);
                    if (postmodel.code == 1)
                    {
                        result.code = 1;
                        result.message = "成功";
                        logBase.PerformContent += "    @成功";
                        result.data = ResultData(performtype,postmodel.data);
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败"; 
                        logBase.PerformContent += "    @失败";
                        result.data = "失败";
                    }
                }
                else
                {
                    logBase.BehaviorType = "-1";
                    logBase.ExecutionTime = DateTimeUtil.TOString("yyyy-MM-dd HH:mm:ss");
                    logBase.PerformContent = "失败";
                    result.code = 2;
                    result.message = "失败";
                    result.data = "未获取准确业务项目";
                }

                logBase.ID = "Business" + DateTimeUtil.TOString("yyyyMMddHHmmss");
                LogUtil.Loger(logBase);
                LogUtil.Closed();
                return result;
            }
            catch (Exception ex)
            {
                loger.Error(ex.Message);

                result.code = 0;
                result.message = "失败";
                result.data = ex.Message;
                logBase.BehaviorType = "-1";
                logBase.ExecutionTime = DateTimeUtil.TOString("yyyy-MM-dd HH:mm:ss");
                logBase.PerformContent = ex.Message;
                logBase.ID = "Business" + DateTimeUtil.TOString("yyyyMMddHHmmss");
                LogUtil.Loger(logBase);
                LogUtil.Closed();
                return result;
                //throw;
            }
        }

        /// <summary>
        /// 返回参数一次处理
        /// 处理结果方便逻辑层赋值
        /// </summary>
        /// <param name="performtype"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private object ResultData(string performtype,object data)
        {
            switch (performtype)
            {
                case "select":
                case "Select":
                    if (data.GetType() == typeof(string))
                    {
                        return null;
                    }
                    else
                    {
                        DataTable result = (DataTable)data;
                        return result;
                    }
                case "Insert":
                case "insert":
                    return data;
                case "delete":
                case "Delete":
                    return data;
                case "Update":
                case "update":
                    return data;
                default:
                    return "输入字符非法！";
            }
            return null;
        }

    }
}
