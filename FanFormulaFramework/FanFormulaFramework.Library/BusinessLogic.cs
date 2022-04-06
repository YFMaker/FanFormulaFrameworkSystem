using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FanFormulaFramework.Library
{
    /// <summary>
    /// 业务逻辑处理类
    /// 根据需要修改或添加
    /// </summary>
    public class BusinessLogic
    {
        static BusinessLogic()
        {

        }

        public static string ConvertToString(object targetValue)
        {
            return Convert.ToString(targetValue);
        }

        public static bool ConvertIntToBoolean(object targetValue)
        {
            return Convert.ToBoolean(targetValue);
        }

        public static bool ConvertToBoolean(object targetValue)
        {
            return Convert.ToBoolean(targetValue);
        }

        public static DateTime ConvertToDateTime(object targetValue)
        {
            return DateTimeUtil.ToTime(ConvertToDateToString(targetValue));
        }

        public static string ConvertToDateToString(object targetValue)
        {
            return DateTimeUtil.TOString(ConvertToDateTime(targetValue),"yyyy-MM-dd HH:mm:ss");
        }

        public static decimal ConvertToDecimal(object targetValue)
        {
            return Convert.ToDecimal(targetValue);
        }

        public static string NewGuid()
        {
            string restul = Guid.NewGuid().ToString("D");

            return restul;
        }

        public static double ConvertToDouble(object targetValue)
        {
            return Convert.ToDouble(targetValue);
        }

        public static float ConvertToFloat(object targetValue)
        {
            return Convert.ToSingle(targetValue);
        }

        public static int ConvertToInt(object targetValue)
        {
            return Convert.ToInt32(targetValue);
        }

        public static int ConvertToInt32(object targetValue)
        {
            return Convert.ToInt32(targetValue);
        }

        public static long ConvertToInt64(object targetValue)
        {
            return Convert.ToInt64(targetValue);
        }

        public static long ConvertToLong(object targetValue)
        {
            return Convert.ToInt32(targetValue);
        }
       

        public static string ConverToSQL(object targetValue)
        {
            return "";
        }

        public static string ConverToSQL<T>(object targetValue)
        {

            return "";
        }

    }
}
