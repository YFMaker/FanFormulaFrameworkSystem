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
            Console.ReadLine();
        }
    }
}
