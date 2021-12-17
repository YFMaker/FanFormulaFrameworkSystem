using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService.Authorized
{
    /// <summary>
    /// 拦截器
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class BasicAuthAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 在控制器执行之前调用
        /// </summary>
        /// <param name="context">执行的上下文</param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // 判断是否加上了不需要拦截
            string authHeader = context.HttpContext.Request.Headers["Authorization"];
            if (!string.IsNullOrEmpty(authHeader))
            {
               
                    //context.Result = new UnauthorizedResult();
                    return;
            }
            else
            {
                context.Result = new UnauthorizedResult();
            }

        }


    }

    /// <summary>
    /// 不需要登陆的地方加个这个空的拦截器
    /// </summary>
    public class NoSignAttribute : ActionFilterAttribute { }
}
