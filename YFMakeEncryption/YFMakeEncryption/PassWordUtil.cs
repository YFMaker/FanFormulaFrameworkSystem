using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YFMakeEncryption
{
    /// <summary>
    /// 密码加密类
    /// </summary>
    public static class PassWordUtil
    {
        #region 秘钥

        /// <summary>
        /// DES秘钥
        /// </summary>
        private static readonly string DESKey = @"yfmadepw";
        /// <summary>
        /// DES向量
        /// </summary>
        private static readonly string DESIV = @"yf202203";

        /// <summary>
        /// RSA秘钥-公钥
        /// </summary>
        private static readonly string RSAPublicKey = "<RSAKeyValue><Modulus>zqkhwCpOOq9cHq09/+x08gdPwiSVcg6d/cAkRXFt6816s+1CzFOY68S/Kc8qTu9cgqlapK/TX1yAumD/h+2I50cV24XcIERqWfPJCtLqIyOpW5X7UFmQtBwrL7tSXvz4jtZGO0fWVyk3ADUoAwwyteDUT5v5JQWYrB/aAHY7yB0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        /// <summary>
        /// RSA秘钥-私钥
        /// </summary>
        private static readonly string RSAPrivateKey = "<RSAKeyValue><Modulus>zqkhwCpOOq9cHq09/+x08gdPwiSVcg6d/cAkRXFt6816s+1CzFOY68S/Kc8qTu9cgqlapK/TX1yAumD/h+2I50cV24XcIERqWfPJCtLqIyOpW5X7UFmQtBwrL7tSXvz4jtZGO0fWVyk3ADUoAwwyteDUT5v5JQWYrB/aAHY7yB0=</Modulus><Exponent>AQAB</Exponent><P>2NpQsTseMsvAzagDF44adQjpAMhxcpfyqZo2cpLYUmrxQeXljCQ0/7pnRQlsgC7DA72Itiwpmbk88xU7Ktpp2w==</P><Q>8/fLqMURvrd8MzzKXosEhejx6f/GabR/gytwxRs+0zJGc0shUR+7m9JTpJ0Is5l7uWqnlCcu/aFVU1oNuNrjZw==</Q><DP>0sO1o9xSqIoylXATuUQrYM7NMC6hXQBkIQW6n7cru0cnv6XDamcSf+7bSlUzeI56ilsf0fewYzGQFK7w9+Ca+w==</DP><DQ>zbq7GgG9Ggeei5KK0LkIQmgSgBH5XjAgixs5yG1WSECQGi9T1BYfXaI6eIkXymP2aoAe+pckUCsZSeWZxrWGpw==</DQ><InverseQ>wIM9wVqRQO0Woz4VzxUYgjNpg1i06pOnGQWFiXwVLfqsYRRNa1l2tCNJBLMPezIApWq6VKrs8Jgjk6D3ihzcvQ==</InverseQ><D>fTqOAiVgrD0RJGG0fT2rC/KUST/j826aHGbvU8lNY6NrJFa0sJ5DvzLE6C/qIlT3iRHYpI0LF/E07DvU/GhbGTuCi/im2TVTaP5igjCZU9zcfbLATqmx0AaiTxv+U65TYjPg5pdhyZU0xbLgebTXpwRNy9itEHkJVp6iBUVcCl0=</D></RSAKeyValue>";

        #endregion

        /*** 功能解释
         * 
         * 密码加密
         * Password encryption
         * 通过对字符串的一次加密（RSA加密），
         * 再对加密过的信息二次加密（DES加密）
         * By encrypting the string once (RSA encryption) and 
         * then encrypting the encrypted information twice (DES encryption)
         * 
         * 能够有效防止密码被直接逆向解密的可能
         * Can effectively prevent the password is directly reverse decryption of the possibility
         * 
         * ***/

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string EncryptedInformation(string password)
        {
            string onceEncryted = EncryptedOnce(password);
            string twiceEncryted = EncryptedTwice(onceEncryted);
            return twiceEncryted;
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="passwordEncryted"></param>
        /// <returns></returns>
        public static string DecryptInformation(string passwordEncryted)
        {
            string onceDecrypt = DecrytOnce(passwordEncryted);
            string twiceDecrypt = DecrytTwice(onceDecrypt);
            return twiceDecrypt;
        }

        #region 加密

        /// <summary>
        /// 一次加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private static string EncryptedOnce(string password)
        {
            //创建RSA对象并载入[公钥]
            RSACryptoServiceProvider rsaPublic = new RSACryptoServiceProvider();
            rsaPublic.FromXmlString(RSAPublicKey);
            //对数据进行加密
            byte[] publicValue = rsaPublic.Encrypt(Encoding.UTF8.GetBytes(password), false);
            string publicStr = Convert.ToBase64String(publicValue);//使用Base64将byte转换为string
            return publicStr;
        }

        /// <summary>
        /// 二次加密
        /// </summary>
        /// <param name="Encryted"></param>
        /// <returns></returns>
        private static string EncryptedTwice(string Encryted)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.GetEncoding("UTF-8").GetBytes(Encryted);
            des.Key = ASCIIEncoding.UTF8.GetBytes(DESKey);
            des.IV = ASCIIEncoding.UTF8.GetBytes(DESIV);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }

        #endregion

        #region 解密

        /// <summary>
        /// 一次解密
        /// </summary>
        /// <param name="passwordEncryted"></param>
        /// <returns></returns>
        private static string DecrytOnce(string passwordEncryted)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = new byte[passwordEncryted.Length / 2];
                for (int x = 0; x < passwordEncryted.Length / 2; x++)
                {
                    int i = (Convert.ToInt32(passwordEncryted.Substring(x * 2, 2), 16));
                    inputByteArray[x] = (byte)i;
                }
                des.Key = ASCIIEncoding.UTF8.GetBytes(DESKey);
                des.IV = ASCIIEncoding.UTF8.GetBytes(DESIV);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                StringBuilder ret = new StringBuilder();
                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        /// <summary>
        /// 二次解密
        /// </summary>
        /// <param name="Decryted"></param>
        /// <returns></returns>
        private static string DecrytTwice(string Decryted)
        {
            try
            {
                //创建RSA对象并载入[私钥]
                RSACryptoServiceProvider rsaPrivate = new RSACryptoServiceProvider();
                rsaPrivate.FromXmlString(RSAPrivateKey);
                //对数据进行解密
                byte[] privateValue = rsaPrivate.Decrypt(Convert.FromBase64String(Decryted), false);//使用Base64将string转换为byte
                string privateStr = Encoding.UTF8.GetString(privateValue);
                return privateStr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        #endregion

    }
}
