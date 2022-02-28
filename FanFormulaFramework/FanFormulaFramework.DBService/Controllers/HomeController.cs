using FanFormulaFramework.DBService.Authorized;
using FanFormulaFramework.DBService.Models;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
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

        private static readonly ILoger<HomeController> loger;

        static HomeController()
        {
            loger = new ILoger<HomeController>();
        }

        [ViewData]
        public string TitleName { get; set; }

        [ViewData]
        public string Message { get; set; }

        public IActionResult Index()
        {
            loger.Information("启动检测");
            TitleName = "启动检测";
            string messagestring = string.Empty;
            DataBaseServiceStart(out messagestring);
            Message = messagestring;
            return View();
        }


        public void DataBaseServiceStart(out string message)
        {
            if (DataBaseUtil.DBServices.Count > 0)
            {
                message = "验证连接池状态：\r\n";
                foreach (var item in DataBaseUtil.DBServices)
                {
                    string DBtype = Enum.GetName(typeof(RequestBusinessType), item.Key) ;
                    string messageforbool = string.Empty;
                    bool isStart = item.Value.IsEnable(out messageforbool);
                    message += "数据库：" + DBtype +" 启动验证："+isStart+" 验证结论"+ messageforbool + "\r\n";
                }
            }
            else
            {
                message = "数据库连接池为空";
            }
        }

        /// <summary>
        /// 查询数据库状态
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("db/[action]")]
        [BasicAuth]
        public ActionResult<object> SelectState()
        {
            Result result = new Result();
            string message = "";
            try
            {
                IFormCollection context = HttpContext.Request.Form;
                //QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int key = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key) != null)
                {
                    
                    bool isEnable = Models.DataBaseUtil.DBServices[(RequestBusinessType)key].IsEnable(out message);
                    if (isEnable)
                    {
                        result.code = 1;
                        result.message = "成功";
                        result.data = message;
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        result.data = message;
                    }
                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    result.data = "未获取到准确参数";
                }
                return result;
            }
            catch (Exception ex)
            {
                loger.Error(message + ex.Message);

                result.code = 0;
                result.message = "失败";
                result.data = ex.Message;
                return result;
            }
        }

        /// <summary>
        /// 启动某个DB服务
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("db/[action]")]
        [BasicAuth]
        public ActionResult<object> StartDB()
        {
            Result result = new Result();
            try
            {
                QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int key = Convert.ToInt32(context["key"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key) != null)
                {

                    if (DataBaseUtil.DBServices.ContainsKey((RequestBusinessType)key))
                    {
                        result.code = 2;
                        result.message = "失败";
                        result.data = "已启动该数据库";
                    }
                    else
                    {
                        switch ((RequestBusinessType)key)
                        {
                            case RequestBusinessType.StaffServer:
                                if (!string.IsNullOrEmpty(BaseSystemInfo.StaffServerDbConnetString))
                                {
                                    DBUtile.DataBaseService StaffDataBase = new DBUtile.DataBaseService(BaseSystemInfo.StaffServerDbType, BaseSystemInfo.StaffServerDbConnetString);
                                    DataBaseUtil.DBServices.Add(RequestBusinessType.StaffServer, StaffDataBase);
                                    result.code = 1;
                                    result.message = "成功";
                                    result.data = "启动" + Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key) + "数据库成功";
                                }
                                else
                                {
                                    result.code = 2;
                                    result.message = "失败";
                                    result.data = "无该数据库连接信息";
                                }
                                break;
                            case RequestBusinessType.CustomerServer:
                                if (!string.IsNullOrEmpty(BaseSystemInfo.CustomerServerDbConnetString))
                                {
                                    DBUtile.DataBaseService CustomerDataBase = new DBUtile.DataBaseService(BaseSystemInfo.CustomerServerDbType, BaseSystemInfo.CustomerServerDbConnetString);
                                    DataBaseUtil.DBServices.Add(RequestBusinessType.CustomerServer, CustomerDataBase);
                                    result.code = 1;
                                    result.message = "成功";
                                    result.data = "启动" + Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key) + "数据库成功";
                                }
                                else
                                {
                                    result.code = 2;
                                    result.message = "失败";
                                    result.data = "无该数据库连接信息";
                                }
                                break;
                            case RequestBusinessType.BusinessServer:
                                if (!string.IsNullOrEmpty(BaseSystemInfo.BusinessServerDbConnetString))
                                {
                                    DBUtile.DataBaseService BusinessDataBase = new DBUtile.DataBaseService(BaseSystemInfo.BusinessServerDbType, BaseSystemInfo.BusinessServerDbConnetString);
                                    DataBaseUtil.DBServices.Add(RequestBusinessType.BusinessServer, BusinessDataBase);
                                    result.code = 1;
                                    result.message = "成功";
                                    result.data = "启动" + Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key) + "数据库成功";
                                }
                                else
                                {
                                    result.code = 2;
                                    result.message = "失败";
                                    result.data = "无该数据库连接信息";
                                }
                                break;
                            case RequestBusinessType.MessageServer:
                                if (!string.IsNullOrEmpty(BaseSystemInfo.MessageServerDbConnetString))
                                {
                                    DBUtile.DataBaseService MessageDataBase = new DBUtile.DataBaseService(BaseSystemInfo.MessageServerDbType, BaseSystemInfo.MessageServerDbConnetString);
                                    DataBaseUtil.DBServices.Add(RequestBusinessType.MessageServer, MessageDataBase);
                                    result.code = 1;
                                    result.message = "成功";
                                    result.data = "启动" + Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key) + "数据库成功";
                                }
                                else
                                {
                                    result.code = 2;
                                    result.message = "失败";
                                    result.data = "无该数据库连接信息";
                                }
                                break;
                            case RequestBusinessType.WorkServer:
                                if (!string.IsNullOrEmpty(BaseSystemInfo.WorkServerDbConnetString))
                                {
                                    DBUtile.DataBaseService WorkDataBase = new DBUtile.DataBaseService(BaseSystemInfo.WorkServerDbType, BaseSystemInfo.WorkServerDbConnetString);
                                    DataBaseUtil.DBServices.Add(RequestBusinessType.WorkServer, WorkDataBase);
                                    result.code = 1;
                                    result.message = "成功";
                                    result.data = "启动"+ Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key)+"数据库成功";
                                }
                                else
                                {
                                    result.code = 2;
                                    result.message = "失败";
                                    result.data = "无该数据库连接信息";
                                }
                                break;
                            default:
                                loger.Error("尝试启动不存在数据库");
                                result.code = 0;
                                result.message = "失败";
                                result.data = "不存在该数据库";
                                break;
                        }
                    }
                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    result.data = "未获取到准确参数";
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
        /// 关闭某个DB服务
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("db/[action]")]
        [BasicAuth]
        public ActionResult<object> CloseDB()
        {
            Result result = new Result();
            try
            {
                QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int key = Convert.ToInt32(context["key"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)key) != null)
                {

                    if (DataBaseUtil.DBServices.ContainsKey((RequestBusinessType)key))
                    {
                        string message = string.Empty;
                        bool isclose = DataBaseUtil.DBServices[(RequestBusinessType)key].IsClose(out message);
                        if (isclose)
                        {
                            DataBaseUtil.DBServices.Remove((RequestBusinessType)key);
                            result.code = 1;
                            result.message = "成功";
                            result.data = "已移除该业务数据";
                        }
                        else
                        {
                            result.code = 2;
                            result.message = "失败";
                            result.data = message;
                        }
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        result.data = "该业务数据未启用";
                    }
                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    result.data = "未获取到准确参数";
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
    }
}
