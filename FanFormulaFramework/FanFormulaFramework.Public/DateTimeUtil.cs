using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{

    public static class DateTimeUtil
    {
        private static System.OperatingSystem osInfo = System.Environment.OSVersion;
        private static System.PlatformID platformID = osInfo.Platform;


        /// <summary>
        /// 获取当前时间
        /// Get the current time
        /// </summary>
        /// <returns></returns>
        public static DateTime Now()
        {
            DateTime dateTime = DateTime.Now;
            if ((int)platformID > 3)//Judgment system
            {
                dateTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            return dateTime;
        }



        /// <summary>
        /// 日期转字符串
        /// Date transfer string
        /// </summary>
        /// <returns></returns>
        public static string TOString()
        {
            DateTime dateTime = Now();
            string result = dateTime.ToString();
            return result;
        }

        /// <summary>
        /// 日期转字符串
        /// Date transfer string
        /// </summary>
        /// <param name="format">format</param>
        /// <returns></returns>
        public static string TOString(string format)
        {
            DateTime dateTime = Now();
            string result = dateTime.ToString(format);
            return result;
        }



    }
}
