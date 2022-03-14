using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YFMakeEncryption
{
    /// <summary>
    /// 标准加密
    /// </summary>
    public static class EncryptionInformation
    {
        private static string PublicKey = @"<RSAKeyValue><Modulus>39TALJtEQ93Akq7uvmsyMDgAVQ1sCNUQX2qBnW/M6Q6b84zOoaFh8ffDRmFOmS+mYI9/1DlcICpeanR+g037BK96i0d3CEqlBBZSBYSEW+XIFCoNCLZdirzXuyEsoglCj3nVl1VIPHRiW/p6sEzAgnvsxYHu0LNVHDX42b8OHBU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private static string PrivateKey = @"<RSAKeyValue><Modulus>39TALJtEQ93Akq7uvmsyMDgAVQ1sCNUQX2qBnW/M6Q6b84zOoaFh8ffDRmFOmS+mYI9/1DlcICpeanR+g037BK96i0d3CEqlBBZSBYSEW+XIFCoNCLZdirzXuyEsoglCj3nVl1VIPHRiW/p6sEzAgnvsxYHu0LNVHDX42b8OHBU=</Modulus><Exponent>AQAB</Exponent><P>69iV2WI3CiZzOB8wMl6vLMPkV8XbynlXik2RqyVLbZkdhnTCcFv/YCbegqrbn+J+J/UqxMAbw/P17wdEuFajdw==</P><Q>8vVSwZB4Rwb6A1klHwUYNZ+v/Isu5AkykTLvzzGe5l7lpbUAwNSJW/tQqPT1CSuhmJRPFDuxIYiwS552dkPn0w==</Q><DP>kHjigoGpmawoFI72ZUSfJlrxe9sWYpemSnBt9VspM4ACGCVaHp4cd/gXgg/L7cs+4JdMla3g1E6TrtLTA+D+zQ==</DP><DQ>0MY2gtaeRIqeNFpaJ7m8//dkxuLjPFka9uKKZ8UAAn3xYN+U8h6wmjXvLgCwv1ya0/49pelVYLeQpqpYqW/YuQ==</DQ><InverseQ>BWuxhfReo+MKlf5KYRknFwxmRch9GeR84hxlcx1YX3nFnx8H7V8eop9ZyO7nzkn1nK3/gerA7NsCNujWDtxXBw==</InverseQ><D>cbJWM9Ji6L5ZtajaaSt2gPvRX2LD//CKso0dbeV+htv+58YcqAmcARdDwBppnHKR5va9jgXdABHFh/nI0dXorVNmffN3/uIplx1v+ord/9KGWFEvfyhqXHWYIxbV9M1IIuDJaaczyvzKzHf+wh8a3AAnviUB3GrRi4ywehQSP/k=</D></RSAKeyValue>";
        
        /// <summary>
        /// 生成秘钥
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string MakeEncryption(string key)
        {
            //创建RSA对象并载入[公钥]
            RSACryptoServiceProvider rsaPublic = new RSACryptoServiceProvider();
            rsaPublic.FromXmlString(PublicKey);
            //对数据进行加密
            byte[] publicValue = rsaPublic.Encrypt(Encoding.UTF8.GetBytes(key), false);
            string publicStr = Convert.ToBase64String(publicValue);//使用Base64将byte转换为string
            return publicStr;
        }

        /// <summary>
        /// 解析秘钥
        /// </summary>
        /// <param name="vale"></param>
        /// <returns></returns>
        public static string ReadEncryption(string vale)
        {
            try
            {
                //创建RSA对象并载入[私钥]
                RSACryptoServiceProvider rsaPrivate = new RSACryptoServiceProvider();
                rsaPrivate.FromXmlString(PrivateKey);
                //对数据进行解密
                byte[] privateValue = rsaPrivate.Decrypt(Convert.FromBase64String(vale), false);//使用Base64将string转换为byte
                string privateStr = Encoding.UTF8.GetString(privateValue);
                return privateStr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
           
        }

    }
}
