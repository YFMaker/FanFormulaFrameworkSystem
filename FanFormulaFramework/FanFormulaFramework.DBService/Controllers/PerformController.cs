using FanFormulaFramework.DBService.Authorized;
using FanFormulaFramework.DBService.Models;
using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService.Controllers
{
    [ApiController]
    [Route("db/[action]")]
    [BasicAuth]
    public class PerformController : Controller
    {
        private static ILoger<PerformController> loger;
        private static LogBase LogBase = new LogBase();
        private static string message;

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
                IFormCollection context = HttpContext.Request.Form;
                //QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {
                    string sql = context["sqlstring"].ToString();
                    LogBase.SQLLINQS = sql;
                    int insert = Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].InsterSQL(sql);
                    if (insert > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        LogBase.INSETERtIME = "成功";
                        result.data = insert;
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        LogBase.INSETERtIME = "失败";
                        result.data = "插入失败";
                    }
                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    LogBase.INSETERtIME = "失败";
                    result.data = "未获取准确业务项目";
                }
                LogBase.ID = DateTime.Now.ToString("LOG-INSERT-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
                return result;
            }
            catch (Exception ex)
            {
                loger.Error(ex.Message);

                result.code = 0;
                result.message = "失败";
                result.data = ex.Message;
                LogBase.INSETERtIME = "失败";
                LogBase.ID = DateTime.Now.ToString("LOG-INSERT-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
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
            Result result = new Result();
            try
            {
                IFormCollection context = HttpContext.Request.Form;
                //QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {
                    string sql = context["sqlstring"].ToString();
                    LogBase.SQLLINQS = sql;
                    int delete = Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].DeleteSQL(sql);
                    if (delete > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        LogBase.INSETERtIME = "成功";
                        result.data = delete;
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        LogBase.INSETERtIME = "失败";
                        result.data = "删除失败";
                    }
                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    LogBase.INSETERtIME = "失败";
                    result.data = "未获取准确业务项目";
                }
                LogBase.ID = DateTime.Now.ToString("LOG-DELETE-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
                return result;
            }
            catch (Exception ex)
            {
                loger.Error(ex.Message);

                result.code = 0;
                result.message = "失败";
                result.data = ex.Message;
                LogBase.INSETERtIME = "失败";
                LogBase.ID = DateTime.Now.ToString("LOG-DELETE-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
                return result;
            }
        }

        /// <summary>
        /// 更改接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Update()
        {
            Result result = new Result();
            try
            {
                IFormCollection context = HttpContext.Request.Form;
                //QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {
                    string sql = context["sqlstring"].ToString();
                    LogBase.SQLLINQS = sql;
                    int update = Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].UpdateSQL(sql);
                    if (update > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        LogBase.INSETERtIME = "成功";
                        result.data = update;
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        LogBase.INSETERtIME = "失败";
                        result.data = "更新失败";
                    }
                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    LogBase.INSETERtIME = "失败";
                    result.data = "未获取准确业务项目";
                }
                LogBase.ID = DateTime.Now.ToString("LOG-UPDATE-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
                return result;
            }
            catch (Exception ex)
            {
                loger.Error(ex.Message);

                result.code = 0;
                result.message = "失败";
                result.data = ex.Message;
                LogBase.INSETERtIME = "失败";
                LogBase.ID = DateTime.Now.ToString("LOG-UPDATE-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
                return result;
            }
        }

        /// <summary>
        /// 查询接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Select()
        {
            Result result = new Result();
            try
            {
                IFormCollection context = HttpContext.Request.Form;
                //QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {
                    string sql = context["sqlstring"].ToString();
                    LogBase.SQLLINQS = sql;
                    DataTable select = Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].SelectSQL(sql);
                    if (select.Rows.Count > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        LogBase.INSETERtIME = "成功";
                        result.data = select;
                    }
                    else
                    {
                        result.code = 1;
                        result.message = "成功";
                        LogBase.INSETERtIME = "成功";
                        result.data = "查询结果为空";
                    }
                }
                else
                {
                    result.code = 2;
                    result.message = "失败";
                    LogBase.INSETERtIME = "失败";
                    result.data = "未获取准确业务项目";
                }
                LogBase.ID = DateTime.Now.ToString("LOG-INSTER-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
                return result;
            }
            catch (Exception ex)
            {
                loger.Error(ex.Message);

                result.code = 0;
                result.message = "失败";
                LogBase.INSETERtIME = "失败";
                result.data = ex.Message;
                LogBase.ID = DateTime.Now.ToString("LOG-INSTER-yyyyMMddHHmmss");
                Models.DataBaseUtil.LogDataBase.InsterSQL<LogBase>(LogBase);
                Models.DataBaseUtil.LogDataBase.IsClose(out message);
                return result;
            }
        }

    }
}
