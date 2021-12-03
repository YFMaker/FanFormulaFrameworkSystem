using FanFormulaFramework.DBService.Models;
using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
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
                    string sql = context["sqlstring"].ToString();
                    int insert= Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].InsterSQL(sql);
                    if (insert > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        result.data = insert;
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        result.data = "插入失败";
                    }
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
            Result result = new Result();
            try
            {
                QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {
                    string sql = context["sqlstring"].ToString();
                    int delete = Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].DeleteSQL(sql);
                    if (delete > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        result.data = delete;
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        result.data = "删除失败";
                    }
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
        /// 更改接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Update()
        {
            Result result = new Result();
            try
            {
                QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {
                    string sql = context["sqlstring"].ToString();
                    int update = Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].UpdateSQL(sql);
                    if (update > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        result.data = update;
                    }
                    else
                    {
                        result.code = 2;
                        result.message = "失败";
                        result.data = "更新失败";
                    }
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
        /// 查询接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<object> Select()
        {
            Result result = new Result();
            try
            {
                QueryCollection context = (QueryCollection)HttpContext.Request.Query;
                int businessKey = Convert.ToInt32(context["businessKey"].ToString());
                if (Enum.GetName(typeof(RequestBusinessType), (RequestBusinessType)businessKey) != null)
                {
                    string sql = context["sqlstring"].ToString();
                    DataTable select = Models.DataBaseUtil.DBServices[(RequestBusinessType)businessKey].SelectSQL(sql);
                    if (select.Rows.Count > 0)
                    {
                        result.code = 1;
                        result.message = "成功";
                        result.data = select;
                    }
                    else
                    {
                        result.code = 1;
                        result.message = "成功";
                        result.data = "查询结果为空";
                    }
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

    }
}
