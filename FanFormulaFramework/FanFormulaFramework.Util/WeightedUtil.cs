/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : WeightedUtil
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
    /// 加权工具类
    /// </summary>
    public static class WeightedUtil
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
        /// 加权
        /// </summary>
        /// <param name="encryptionType"></param>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Weighted(EncryptionType encryptionType, string value, string key)
        {
            switch (encryptionType)
            {
                case EncryptionType.AES:
                    return WeightedAES(value, key);
                case EncryptionType.DES:
                    return WeightedDES(value, key);
                case EncryptionType.Base64:
                    return WeightedBase64(value);
                default:
                    return "";
            }
        }


        /// <summary>
        ///  AES加权
        /// </summary>
        /// <param name="value"></param>
        /// <param name="aeskey"></param>
        /// <returns></returns>
        private static string WeightedAES(string value,string aeskey)
        {
            if (string.IsNullOrEmpty(aeskey))
            {
                aeskey = AESKey;
            }
            return AESEncrypt(value, aeskey);
        }

        /// <summary>  
        /// AES加密  
        /// </summary>
        private static string AESEncrypt(string value, string _aeskey = null)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(_aeskey);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(value);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }


        /// <summary>
        /// DES加权
        /// </summary>
        /// <param name="value"></param>
        /// <param name="deskey"></param>
        /// <returns></returns>
        private static string WeightedDES(string value, string deskey)
        {
            if (string.IsNullOrEmpty(deskey))
            {
                deskey = DESKey;
            }
            return DESEncrypt(value, deskey);
        }

        /// <summary>  
        /// DES加密  
        /// </summary>
        private static string DESEncrypt(string value, string _deskey = null)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(_deskey);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(value);

            DESCryptoServiceProvider rDel = new DESCryptoServiceProvider();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// base64加权
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string WeightedBase64(string value)
        {
            return Base64Encode(value);
        }

        /// <summary>
        /// base64编码
        /// </summary>
        /// <returns></returns>
        private static string Base64Encode(string value)
        {
            string result = Convert.ToBase64String(Encoding.Default.GetBytes(value));
            return result;
        }
    }
}
