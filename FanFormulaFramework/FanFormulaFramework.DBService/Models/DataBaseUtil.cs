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
        public static Dictionary<RequestBusinessType, DataBaseService> DBServices = new Dictionary<RequestBusinessType, DataBaseService>();

        /// <summary>
        /// 初始化
        /// </summary>
        public static void init()
        {
            if (!string.IsNullOrEmpty(BaseSystemInfo.StaffServerDbConnetString))
            {
                DataBaseService StaffDataBase = new DataBaseService(BaseSystemInfo.StaffServerDbType, BaseSystemInfo.StaffServerDbConnetString);
                DBServices.Add(RequestBusinessType.StaffServer, StaffDataBase);
            }
            if (!string.IsNullOrEmpty(BaseSystemInfo.CustomerServerDbConnetString))
            {
                DataBaseService CustomerDataBase = new DataBaseService(BaseSystemInfo.CustomerServerDbType, BaseSystemInfo.CustomerServerDbConnetString);
                DBServices.Add(RequestBusinessType.CustomerServer, CustomerDataBase);
            }
            if (!string.IsNullOrEmpty(BaseSystemInfo.BusinessServerDbConnetString))
            {
                DataBaseService BusinessDataBase = new DataBaseService(BaseSystemInfo.BusinessServerDbType, BaseSystemInfo.BusinessServerDbConnetString);
                DBServices.Add(RequestBusinessType.BusinessServer, BusinessDataBase);
            }
            if (!string.IsNullOrEmpty(BaseSystemInfo.MessageServerDbConnetString))
            {
                DataBaseService MessageDataBase = new DataBaseService(BaseSystemInfo.MessageServerDbType, BaseSystemInfo.MessageServerDbConnetString);
                DBServices.Add(RequestBusinessType.MessageServer, MessageDataBase);
            }
            if (!string.IsNullOrEmpty(BaseSystemInfo.WorkServerDbConnetString))
            {
                DataBaseService WorkDataBase = new DataBaseService(BaseSystemInfo.WorkServerDbType, BaseSystemInfo.WorkServerDbConnetString);
                DBServices.Add(RequestBusinessType.WorkServer, WorkDataBase);
            }
        }
    }
}
