using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

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
       

        public static string ConverToSQL(string TableName,List<string> selectvalue,Dictionary<string,object> whereDate=null)
        {
            StringBuilder sqlstring = new StringBuilder();
            sqlstring.Append("select ");
            foreach (var item in selectvalue)
            {
                sqlstring.AppendFormat("{0},", item);
            }
            sqlstring.Remove(sqlstring.Length - 1, 1);
            sqlstring.AppendFormat(" from {0}", TableName);
            if (whereDate != null)
            {
                sqlstring.Append(" where 1=1");
                foreach (var item in whereDate.Keys)
                {
                    string sqlwhere = string.Empty;
                    if (whereDate[item].GetType().Name == "string")
                    {
                        sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                    }
                    else if (whereDate[item].GetType().Name == "int")
                    {
                        sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                    }
                    sqlstring.Append(sqlwhere);
                }
            }
            return sqlstring.ToString();
        }

        public static string ConverToSQL<T>(T targetValue,string TableName, MakeType type = MakeType.Inster, Dictionary<string, object> wheredate = null)
        {
            string sql = DataUtilLibrary.MakeSqlstring<T>(targetValue, type, wheredate);
            string entityname = typeof(T).Name;
            sql=sql.Replace(entityname, TableName);
            return sql;
        }

    }
}
