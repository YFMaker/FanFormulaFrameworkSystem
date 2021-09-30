using FanFormulaFramework.DBUtile;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    public static partial class BaseSystemInfo
    {
        /// <summary>
        /// 员工服务数据库类别
        /// </summary>
        public static CurrentDbType StaffServerDbType = CurrentDbType.MicrosoftSQLServer;

        /// <summary>
        /// 客户服务数据库类别
        /// </summary>
        public static CurrentDbType CustomerServerDbType = CurrentDbType.MicrosoftSQLServer;

        /// <summary>
        /// 业务服务数据库类别
        /// </summary>
        public static CurrentDbType BusinessServerDbType = CurrentDbType.MicrosoftSQLServer;

        /// <summary>
        /// 消息服务数据库类别
        /// </summary>
        public static CurrentDbType MessageServerDbType = CurrentDbType.MicrosoftSQLServer;

        /// <summary>
        /// 工作流服务数据库类别
        /// </summary>
        public static CurrentDbType WorkServerDbType = CurrentDbType.MicrosoftSQLServer;

        /// <summary>
        /// 数据库连接字符串是否加密
        /// </summary>
        public static bool DbConnetEncryptionstring = false;

        private static string staffServerDbConnetString = string.Empty;

        public static string StaffServerDbConnetString
        {
            get
            {
                if (string.IsNullOrEmpty(staffServerDbConnetString))
                {

                }
                return "";
            }
            set
            {
                staffServerDbConnetString = value;
            }
        }
    }
}
