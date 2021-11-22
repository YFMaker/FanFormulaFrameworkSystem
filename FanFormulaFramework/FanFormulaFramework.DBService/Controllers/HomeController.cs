using FanFormulaFramework.DBService.Models;
using FanFormulaFramework.Public;
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
        [ViewData]
        public string Message { get; set; }

        public IActionResult Index()
        {
            string messagestring = string.Empty;
            DataBaseServiceStart(out messagestring);
            Message = messagestring;
            return View();
        }


        public void DataBaseServiceStart(out string message)
        {
            if (DataBaseUtil.DBServices.Count > 0)
            {
                message = "验证连接池状态：/r/n";
                foreach (var item in DataBaseUtil.DBServices)
                {
                    string DBtype = item.Key;
                    string messageforbool = string.Empty;
                    bool isStart = item.Value.IsEnable(out messageforbool);
                    message += "数据库：" + DBtype +" 启动验证："+isStart+" 验证结论"+ messageforbool + "/r/n";
                }
            }
            else
            {
                message = "数据库连接池为空";
            }
        }

    }
}
