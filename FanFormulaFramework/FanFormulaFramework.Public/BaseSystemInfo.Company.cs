using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统核心信息-公司基础信息
    /// </summary>
    public partial class BaseSystemInfo
    {
        /// <summary>
        /// 公司电话
        /// </summary>
        public static string CompanyPhone = "010-61169797";

        /// <summary>
        /// 公司名称
        /// </summary>
        public static string CompanyName = "运行于某公司";

        /// <summary>
        /// 当前客户公司电话
        /// </summary>
        public static string CustomerCompanyPhone = "13716040853";

        /// <summary>
        /// 错误邮件发送目标 ; 分隔
        /// </summary>
        public static string ErrorReportEmailTo = "promaker@outlook.com";

        /// <summary>
        /// 错误信息反馈地址
        /// </summary>
        public static string ErrorFeedbackUrl = "";

        /// <summary>
        /// 邮件服务器地址
        /// </summary>
        public static string MailServer = "";

        /// <summary>
        /// 邮件服务用户名
        /// </summary>
        public static string MailUserName = "";

        /// <summary>
        /// 邮件服务密码
        /// </summary>
        public static string MailPassWord = "";

        /// <summary>
        /// 要求用户注册的信息
        /// </summary>
        public static string ResgisterException = "用户您好，请您联系： 运行于某公司 某人 手机：13716040853 电子邮件：promaker@outlook.com 对软件进行注册。";
    }
}
