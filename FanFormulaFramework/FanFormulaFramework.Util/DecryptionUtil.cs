/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : DecryptionUtil
 CreatUser: YiFan
 Created  : 2021-9-30 16:02:02
 Summary  : 

 ===============================================================================================*/
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FanFormulaFramework.Util
{
    /// <summary>
    /// 解密工具类
    /// </summary>
    public static class DecryptionUtil
    {
        /// <summary>
        /// 默认初始化AES变量
        /// </summary>
        private static readonly string AESKey = "[45/*YUIdse..e;]";
        /// <summary>
        /// 默认初始化DES变量
        /// </summary>
        private static readonly string DESKey = "[&HdN72]";

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="encryptionType"></param>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decryption(EncryptionType encryptionType,string value, string key)
        {
            switch (encryptionType)
            {
                case EncryptionType.AES:
                    return DecryptionAES(value, key);
                case EncryptionType.DES:
                    return DecryptionDES(value, key);
                case EncryptionType.Base64:
                    return DecryptionBase64(value);
                default:
                    return "";
            }
        }


        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="value"></param>
        /// <param name="aeskey"></param>
        /// <returns></returns>
        private static string DecryptionAES(string value,string aeskey)
        {
            if (string.IsNullOrEmpty(aeskey))
            {
                aeskey = AESKey;
            }
            return AESDecrypt(value, aeskey);
        }

        /// <summary>  
        /// AES解密  
        /// </summary>
        private static string AESDecrypt(string value, string _aeskey = null)
        {
            try
            {
                byte[] keyArray = Encoding.UTF8.GetBytes(_aeskey);
                byte[] toEncryptArray = Convert.FromBase64String(value);

                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = rDel.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Encoding.UTF8.GetString(resultArray);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="value"></param>
        /// <param name="deskey"></param>
        /// <returns></returns>
        private static string DecryptionDES(string value, string deskey)
        {
            if (string.IsNullOrEmpty(deskey))
            {
                deskey = DESKey;
            }
            return DESDecrypt(value, deskey);
        }

        /// <summary>  
        /// DES解密  
        /// </summary>
        private static string DESDecrypt(string value, string _deskey = null)
        {
            try
            {
                if (string.IsNullOrEmpty(_deskey))
                {
                    _deskey = DESKey;
                }
                byte[] keyArray = Encoding.UTF8.GetBytes(_deskey);
                byte[] toEncryptArray = Convert.FromBase64String(value);

                DESCryptoServiceProvider rDel = new DESCryptoServiceProvider();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = rDel.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Encoding.UTF8.GetString(resultArray);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// base64解密
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string DecryptionBase64(string value)
        {
            return Base64Decode(value);
        }

        /// <summary>
        /// base64解码
        /// </summary>
        /// <returns></returns>
        private static string Base64Decode(string value)
        {
            string result = Encoding.Default.GetString(Convert.FromBase64String(value));
            return result;
        }
    }
}
