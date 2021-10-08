/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : SystemInfo
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using FanFormulaFramework.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统根架构信息
    /// 
    /// 修改记录：
    ///           1- 2021.9.29   衣凡   创建类。 
    /// 
    /// <CreatUser>
    ///     衣凡
    /// </CreatUser>
    /// <CreatDateTime>
    ///     2021-9-29 16:43:20
    /// </CreatDateTime>
    /// </summary>
    public static partial class BaseSystemInfo
    {

        /// <summary>
        /// 系统版本号
        /// </summary>
        public static string SystemVerion="1.0";
        /// <summary>
        /// 系统归属公司
        /// </summary>
        public static string SystemCompany="YiFan Company";

        /// <summary>
        /// 程序名称
        /// </summary>
        public static string SystemName { get; set; }

        /// <summary>
        /// 系统图标文件
        /// </summary>
        public static readonly string SystemAppIco = "Resources\\Form.ico";

        /// <summary>
        /// 程序介绍
        /// </summary>
        public static string SystemInfoValue { get; set; }

        /// <summary>
        /// 软件密码加权
        /// </summary>
        public static readonly string SystemPassWordID = "this is a password";

        /// <summary>
        /// 软件加密加权
        /// </summary>
        public static readonly string SystemEncryptionID = "this is a encryption";

        /// <summary>
        /// 软件注册码
        /// </summary>
        public static string SystemRegistrationCode { get; set; }

        /// <summary>
        /// 系统数据库连接是否加密
        /// </summary>
        public static bool SystemDataBaseIsWeighted = false;

        /// <summary>
        /// 数据库连接加密方式
        /// </summary>
        public static EncryptionType SystemDataBaseIsWeightedType = EncryptionType.AES;

        /// <summary>
        /// 是否保存行为操作记录
        /// </summary>
        public static bool HandleIsSave { get; set; }

        /// <summary>
        /// 每个操作是否进行信息提示。
        /// </summary>
        public static bool ShowInformation = true;

        /// <summary>
        /// 时间格式
        /// </summary>
        public static readonly string TimeFormat = "HH:mm:ss";

        /// <summary>
        /// 日期短格式
        /// </summary>
        public static readonly string DateFormat = "yyyy-MM-dd";

        /// <summary>
        /// 日期长格式
        /// </summary>
        public static readonly string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// UserConfig,FileConfiguration,RegistryConfig 用户配置，配置，注册表 读取参数
        /// </summary>
        public static ConfigurationCategory ConfigurationCategory = ConfigurationCategory.FileConfiguration;

        /// <summary>
        /// 用户锁
        /// </summary>
        public static object UserLock = new object();

        /// <summary>
        /// 用户是否登录
        /// </summary>
        public static bool UserIsLogon = false;

        /// <summary>
        /// 用户在线状态
        /// </summary>
        public static int UserOnLineState = 0;

    }
}
