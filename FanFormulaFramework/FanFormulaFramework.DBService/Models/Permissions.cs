using FanFormulaFramework.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService.Models
{
    public static class Permissions
    {
        private static readonly ILoger loger;
        public static string SecurityCode;

        static Permissions()
        {
            loger = new ILoger();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            ///make this start new code
            ///
            SecurityCode = "ssssssssss";


            loger.Information("安全秘钥："+SecurityCode);
        }
    }
}
