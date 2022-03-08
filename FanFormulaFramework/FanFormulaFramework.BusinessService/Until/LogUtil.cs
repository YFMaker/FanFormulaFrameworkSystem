using FanFormulaFramework.BusinessService.Models;
using FanFormulaFramework.DBUtile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Until
{
    public static class LogUtil
    {

        /// <summary>
        /// 日志记录
        /// </summary>
        private static DataBaseService LogDataBase;

        public static void Init()
        {
            LogDataBase = new DataBaseService(CurrentDbType.Sqlite, "Data Source=Log.db;Pooling=true;FailIfMissing=false");
        }


        public static void Loger(LogBase logBase)
        {
            LogDataBase.InsterSQL<LogBase>(logBase);
        }

        public static void Closed()
        {
            string message = "";
            LogDataBase.IsClose(out message);
        }
    }
}
