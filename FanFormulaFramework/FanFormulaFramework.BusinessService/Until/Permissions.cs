using FanFormulaFramework.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Until
{
    /// <summary>
    /// 安全秘钥检测
    /// </summary>
    public static class Permissions
    {

        private static string PrivateKey;

        public static void Init()
        {
            PrivateKey = BaseSystemInfo.SystemRegistrationCode;
        }

        /// <summary>
        /// 因业务服务使用时需要做安全校验，
        /// 使用注册码字段进行校验。
        /// 后期可以更改为业务服务有效性认证。
        /// 如：授权有效期等
        /// </summary>
        /// <param name="Regisstring"></param>
        /// <returns></returns>
        public static bool IsReality(string Regisstring)
        {
            if (PrivateKey == Regisstring)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
