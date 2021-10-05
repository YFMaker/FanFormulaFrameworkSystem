using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统信息安全信息
    /// </summary>
    public partial class BaseSystemInfo
    {
        /// <summary>
        /// 密码错误锁定次数
        /// </summary>
        public static int PassWordErrorLockLimt = 10;

        /// <summary>
        /// 连续N次输错密码后 锁定登录周期（分钟）
        /// 若为0 表示账户无效强制锁死
        /// </summary>
        public static int PassWordErrorLockCycle = 5;

        /// <summary>
        /// 是否判断大小写
        /// </summary>
        public static bool MatchCaps = true;

        /// <summary>
        /// 最多数据行数限制
        /// </summary>
        public static int TopDataBaseLimt = 200;

        /// <summary>
        /// 强类型密码管理
        /// 密码包含 字母 数字 字符
        /// </summary>
        public static bool CheckPassWordStrength = false;

        /// <summary>
        /// 服务器端加密存储
        /// </summary>
        public static bool ServerEncryptPassWord = true;

        /// <summary>
        /// 密码长度限制
        /// </summary>
        public static int PassWordMiniLength = 8;

        /// <summary>
        /// 密码包含字母
        /// </summary>
        public static bool LetterInPassWord = true;

        /// <summary>
        /// 修改密码时间周期（月）
        /// </summary>
        public static int ChangePassWordTime = 3;

        /// <summary>
        /// 用户名长度限制
        /// </summary>
        public static int AccountNameMiniLength = 2;

        /// <summary>
        /// 密码加权
        /// </summary>
        public static string PassWordEncryptionKey = "this is password for password";

        /// <summary>
        /// 绝对管理员（大于全部等级设计）
        /// 仅供服务端遠程連接使用
        /// </summary>
        public static readonly string ServerUserName = "management";
        /// <summary>
        /// 绝对管理员密码（大于全部等级设计）
        /// 仅供服务端遠程連接使用
        /// </summary>
        public static readonly string ServerPassWord = "rootPassWord";
    }
}
