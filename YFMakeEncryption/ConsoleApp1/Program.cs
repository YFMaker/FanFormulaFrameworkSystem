using System;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DSACryptoServiceProvider dsac = new DSACryptoServiceProvider();
            dsac.ToXmlString(false);//公钥
            dsac.ToXmlString(true);//私钥 
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            using (StreamWriter writer = new StreamWriter("PrivateKey.xml", false))  //这个文件要保密...
            {
                writer.WriteLine(rsa.ToXmlString(true));
            }
            using (StreamWriter writer = new StreamWriter("PublicKey.xml", false))
            {
                writer.WriteLine(rsa.ToXmlString(false));

            }
        }
    }
}
