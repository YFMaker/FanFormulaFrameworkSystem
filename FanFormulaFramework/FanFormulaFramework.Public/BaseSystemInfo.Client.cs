using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统核心信息客户端
    /// </summary>
    public partial class BaseSystemInfo
    {
        /// <summary>
        /// 主窗体
        /// </summary>
        public static string MainForm = "FrmFanFormulaMain";

        /// <summary>
        /// 登录窗口
        /// </summary>
        public static string LogOnForm = "FrmLogOn";

        /// <summary>
        /// Cookie 过期天数设置
        /// </summary>
        public static int CookieExpires = 30;

        /// <summary>
        /// 配置文件
        /// </summary>
        public static string ConfigFile = "config.json";

        /// <summary>
        /// 是否启用即时消息
        /// </summary>
        public static bool UseMessge = true;

        /// <summary>
        /// 当前用户公司
        /// </summary>
        public static string CurrentCompany = string.Empty;

        /// <summary>
        /// 当前用户用户名
        /// </summary>
        public static string CurrentUserName = string.Empty;

        /// <summary>
        /// 当前用户密码
        /// </summary>
        public static string CurrentPassWord = string.Empty;

        /// <summary>
        /// 是否记住密码
        /// </summary>
        public static bool RemendPassWord = true;

        /// <summary>
        /// 是否自动登录
        /// </summary>
        public static bool AutoLogOn = true;

        /// <summary>
        /// 客户端加密存储
        /// </summary>
        public static bool ClientEncryptionPassWord = true;

        /// <summary>
        /// 动态加载
        /// </summary>
        public static bool OrganizeDynamicLoading = true;

        /// <summary>
        /// 多语言
        /// </summary>
        public static bool Multilingual = true;

        /// <summary>
        /// 当前语言
        /// </summary>
        public static string CurrentLanguage = "zh-CN";
    }
}
