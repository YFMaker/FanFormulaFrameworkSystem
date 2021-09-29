/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : Program
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using FanFormulaFramework.Public;
using System;

namespace FanFormulaFramework
{
    class Program
    {
        /// <summary>
        /// 测试控制台
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ILoger<Program> loger = new ILoger<Program>();
            loger.Information("321321");
            loger.Error("2222");
            Console.WriteLine(DateTime.Today);
            BaseSystemInfo.SystemVerion = "111";
            //DateTimeUtil.TOString();
            Console.ReadLine();
        }
    }
}
