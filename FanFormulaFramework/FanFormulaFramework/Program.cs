/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : Program
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
using FanFormulaFramework.Util;
using System;
using System.Text;

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
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.WriteLine(Encoding.GetEncoding("GB2312"));
            Console.WriteLine("Hello World!");
            Console.WriteLine("!");
            ILoger<Program> loger = new ILoger<Program>();
            loger.Information("321321");
            loger.Error("2222");
            Console.WriteLine(DateTime.Today);
            BaseSystemInfo.SystemVerion = "111";
            ILoger loger1 = new ILoger();
            loger1.Information("222");
            //ConfigurationManagerd configurationManagerd = new ConfigurationManagerd("config.json");
            string dd = ConfigurationManagerd.Appsetting<string>("DataString", "5556w");
            loger.Information(dd);
            ConfigurationManagerd configurationManagerd = new ConfigurationManagerd("appseeting.json");
            loger.Information(ConfigurationManagerd.Appsetting<bool>("ddddd").ToString());
            loger.Information(MultiLanguage.NowLanguageString("叁貳壹", "mandarin"));
            //DateTimeUtil.TOString();
            Console.ReadLine();
        }
    }
}
