/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : DateTimeUtil
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 时间工具类
    /// Represents an instant in time, typically expressed as a date and time of day.
    /// </summary>
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
        /// 当前日期0时
        /// Gets the current date.
        /// </summary>
        /// <returns></returns>
        public static DateTime ToDay()
        {
            DateTime dateTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
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

        /// <summary>
        /// 日期转字符串
        /// Date transfer string
        /// </summary>
        /// <param name="dateTime">dateTime</param>
        /// <param name="format">format</param>
        /// <returns></returns>
        public static string TOString(DateTime dateTime,string format)
        {
            DateTime _dateTime = dateTime;
            string result = _dateTime.ToString(format);
            return result;
        }

    }
}
