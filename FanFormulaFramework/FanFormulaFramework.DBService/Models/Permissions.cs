using FanFormulaFramework.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFMakeEncryption;

namespace FanFormulaFramework.DBService.Models
{
    public static class Permissions
    {
        private static readonly ILoger loger;
        private static string SecurityCode;
        private static string PrivateKey;
        private static string Special = "wJTCoBPTmODZZ0t";
        private static string Independent = "#";
        private static string Checkcharacter = "^";

        static Permissions()
        {
            loger = new ILoger();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            ///make this start new code
            ///Absolute temporary key generation based on time, 
            ///special encoding, independent character, check character, reference character
            ///秘钥根据每次服务开启不同随机生成
            SecurityCode = DateTime.Now.ToString("yyyyMMddHHmmss") + Special + Independent + Checkcharacter+BaseSystemInfo.ServerRegisterKey;
            string oneMake = EncryptionInformation.MakeEncryption(SecurityCode);
            string publickey = oneMake.Substring(0, 15);
            PrivateKey = oneMake.Substring(15, oneMake.Length-15);
            loger.Information("安全秘钥："+ publickey);
        }

        /// <summary>
        /// 核验
        /// </summary>
        /// <param name="publickey"></param>
        /// <returns></returns>
        public static bool IsReality(string publickey)
        {
            string oneMake = publickey + PrivateKey;
            string reality = EncryptionInformation.ReadEncryption(oneMake);
            if (reality == SecurityCode)
            {
                loger.Information("安全秘钥验证：通过");
                return true;
            }
            else
            {
                loger.Information("安全秘钥验证：失败");
                return false;
            }
        }


    }
}
