/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : SystemInfo
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
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
        public static string SystemAppIco = "Resources\\Form.ico";

        /// <summary>
        /// 程序介绍
        /// </summary>
        public static string SystemInfoValue { get; set; }

        /// <summary>
        /// 软件密码加权
        /// </summary>
        public static string SystemPassWordID { get; set; }

        /// <summary>
        /// 软件加密加权
        /// </summary>
        public static string SystemEncryptionID { get; set; }

        /// <summary>
        /// 软件注册码
        /// </summary>
        public static string SystemRegistrationCode { get; set; }

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
        public static string TimeFormat = "HH:mm:ss";

        /// <summary>
        /// 日期短格式
        /// </summary>
        public static string DateFormat = "yyyy-MM-dd";

        /// <summary>
        /// 日期长格式
        /// </summary>
        public static string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";



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
