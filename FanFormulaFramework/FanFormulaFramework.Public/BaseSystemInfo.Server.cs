using FanFormulaFramework.DBUtile;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统核心信息服务端
    /// </summary>
    public partial class BaseSystemInfo
    {
        /// <summary>
        /// 主机地址
        /// Host="192.168.0.1"
        /// </summary>
        public static string Host = string.Empty;

        /// <summary>
        /// 端口号
        /// </summary>
        public static int Port = 8988;

        /// <summary>
        /// 数据库类型（设计模型默认概念为全库统一数据库类型）
        /// 默认数据库MS SQL SERVER
        /// </summary>
        public static CurrentDbType DataBaseType = CurrentDbType.MicrosoftSQLServer;

        /// <summary>
        /// 允许新用户注册
        /// </summary>
        public static bool NewUserRegister = true;

        /// <summary>
        /// 禁止用户重复登录
        /// 只允许登录一次
        /// </summary>
        public static bool UserOnLineLock = true;

        /// <summary>
        /// 软件是否需要注册
        /// </summary>
        public static bool NeedRegister = true;

        /// <summary>
        /// 服务码
        /// </summary>
        public static string ServerRegisterKey = string.Empty;

        /// <summary>
        /// 服务端缓存机制
        /// </summary>
        public static bool ServerCache = false;

        private static string systemcode = string.Empty;
        /// <summary>
        /// 系统设置
        /// </summary>
        public static string SystemCode
        {
            get
            {
                if (string.IsNullOrEmpty(systemcode))
                {
                    if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("SystemCode")))
                    {
                        systemcode = ConfigurationManagerd.Appsetting<string>("SystemCode");
                    }
                    if (string.IsNullOrEmpty(systemcode))
                    {
                        systemcode = "Default";
                    }

                }

                return systemcode;
            }

            set
            {
                systemcode = value;
            }
        }

        /// <summary>
        /// 检测周期
        /// 在线周期检测
        /// 5分钟+40秒循环延误
        /// </summary>
        public static int OnLineTimeOut = 5 * 60 + 40;

        /// <summary>
        /// 每1分钟 检测在线情况
        /// Message服务检测
        /// </summary>
        public static int OnLineCheck = 1 * 60;

        /// <summary>
        /// 锁不住记录循环次数（DB服务）
        /// </summary>
        public static int LockNoWaitCount = 5;

        /// <summary>
        /// 锁不住记录等待时长（DB服务）
        /// </summary>
        public static int LockNoWaitTickTime = 30;

        /// <summary>
        /// 上传文件目录
        /// </summary>
        public static string UploadDirectory = "UpLoadDocument/";

        /// <summary>
        /// 默认密码
        /// </summary>
        public static string DefaultPassWord = "123456";
    }
}
