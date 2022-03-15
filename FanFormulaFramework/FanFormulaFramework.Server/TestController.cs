using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Server
{
    public class TestController : IControllers
    {
        public TestController()
        {
            Logger = new ILoger<IControllers>();
        }

        [HttpGet]
        public ActionResult<object> Qet()
        {
           
            return BaseSystemInfo.ServerUrl;
        }
    }
}
