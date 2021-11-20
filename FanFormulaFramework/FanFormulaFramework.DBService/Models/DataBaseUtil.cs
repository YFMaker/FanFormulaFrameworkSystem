using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService.Models
{
    public static class DataBaseUtil
    {
        /// <summary>
        /// 数据库池
        /// </summary>
        private static Dictionary<string, DataBaseService> DBServices = new Dictionary<string, DataBaseService>();




        /// <summary>
        /// 初始化
        /// </summary>
        public static void init()
        {


            if (!string.IsNullOrEmpty(BaseSystemInfo.StaffServerDbConnetString))
            {
                DataBaseService StaffDataBase = new DataBaseService(BaseSystemInfo.StaffServerDbType, BaseSystemInfo.StaffServerDbConnetString);
                DBServices.Add("Staff", StaffDataBase);
            }


        }
    }
}
