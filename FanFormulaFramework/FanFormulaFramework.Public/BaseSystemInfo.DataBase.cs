using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 数据库连接类
    /// </summary>
    public static partial class BaseSystemInfo
    {

        private static ILoger loger = new ILoger();
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
        /// <summary>
        /// 员工服务数据库连接字符串
        /// </summary>
        public static string StaffServerDbConnetString
        {
            get
            {
                if (!string.IsNullOrEmpty(staffServerDbConnetString))
                {
                    if (SystemDataBaseIsWeighted)
                    {
                        return DecryptionUtil.Decryption(SystemDataBaseIsWeightedType, staffServerDbConnetString, SystemEncryptionID);
                    }
                    else
                    {
                        return staffServerDbConnetString;
                    }
                }
                else
                {
                    loger.Warning("员工服务数据库连接字符串非法！");
                    return "";
                }
            }
            set
            {
                staffServerDbConnetString = value;
            }
        }

        private static string customerServerDbConnetString = string.Empty;
        /// <summary>
        /// 客户服务数据库连接字符串
        /// </summary>
        public static string CustomerServerDbConnetString
        {
            get
            {
                if (!string.IsNullOrEmpty(customerServerDbConnetString))
                {
                    if (SystemDataBaseIsWeighted)
                    {
                        return DecryptionUtil.Decryption(SystemDataBaseIsWeightedType, customerServerDbConnetString, SystemEncryptionID);
                    }
                    else
                    {
                        return customerServerDbConnetString;
                    }
                }
                else
                {
                    loger.Warning("客户服务数据库连接字符串非法！");
                    return "";
                }
            }
            set
            {
                customerServerDbConnetString = value;
            }
        }

        private static string businessServerDbConnetString = string.Empty;
        /// <summary>
        /// 业务服务数据库连接字符串
        /// </summary>
        public static string BusinessServerDbConnetString
        {
            get
            {
                if (!string.IsNullOrEmpty(businessServerDbConnetString))
                {
                    if (SystemDataBaseIsWeighted)
                    {
                        return DecryptionUtil.Decryption(SystemDataBaseIsWeightedType, businessServerDbConnetString, SystemEncryptionID);
                    }
                    else
                    {
                        return businessServerDbConnetString;
                    }
                }
                else
                {
                    loger.Warning("客户服务数据库连接字符串非法！");
                    return "";
                }
            }
            set
            {
                businessServerDbConnetString = value;
            }
        }

        private static string messageServerDbConnetString = string.Empty;
        /// <summary>
        /// 消息服务数据库连接字符串
        /// </summary>
        public static string MessageServerDbConnetString
        {
            get
            {
                if (!string.IsNullOrEmpty(messageServerDbConnetString))
                {
                    if (SystemDataBaseIsWeighted)
                    {
                        return DecryptionUtil.Decryption(SystemDataBaseIsWeightedType, messageServerDbConnetString, SystemEncryptionID);
                    }
                    else
                    {
                        return messageServerDbConnetString;
                    }
                }
                else
                {
                    loger.Warning("客户服务数据库连接字符串非法！");
                    return "";
                }
            }
            set
            {
                messageServerDbConnetString = value;
            }
        }

        private static string workServerDbConnetString = string.Empty;
        /// <summary>
        /// 工作流服务数据库连接字符串
        /// </summary>
        public static string WorkServerDbConnetString
        {
            get
            {
                if (!string.IsNullOrEmpty(workServerDbConnetString))
                {
                    if (SystemDataBaseIsWeighted)
                    {
                        return DecryptionUtil.Decryption(SystemDataBaseIsWeightedType, workServerDbConnetString, SystemEncryptionID);
                    }
                    else
                    {
                        return workServerDbConnetString;
                    }
                }
                else
                {
                    loger.Warning("客户服务数据库连接字符串非法！");
                    return "";
                }
            }
            set
            {
                workServerDbConnetString = value;
            }
        }
    }
}
