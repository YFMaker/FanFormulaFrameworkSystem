/***-----------------
 * 
 * UserName：衣凡
 * UserTimer：2022年3月14日16:26:41
 * 
 * 
 * 
 * 
 * -----------------**/
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Server
{
    /// <summary>
    /// 基础控制器
    /// 每个服务控制器均需要继承该控制器
    /// 同时，Model类库中基础MOdel同样在该控制器内嵌。
    /// 
    /// Base controller
    /// Each service controller needs to inherit this controller
    /// At the same time, the base Model in the Model class library is also embedded in the controller.
    /// </summary>
    [ApiController]
    [Route("service/[action]")]
    public class IControllers : Controller
    {
        protected ILoger<IControllers> Logger;
    }
}
