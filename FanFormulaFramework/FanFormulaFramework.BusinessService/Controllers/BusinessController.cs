using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Controllers
{
    [ApiController]
    [Route("operation/[action]")]
    public class BusinessController : Controller
    {

        private static ILoger<BusinessController> loger;

        public BusinessController()
        {
            loger = new ILoger<BusinessController>();
        }




    }
}
