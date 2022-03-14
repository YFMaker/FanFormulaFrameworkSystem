using System;
using System.IO;
using System.IO.Compression;
using YFMakeEncryption;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string dd = Console.ReadLine();

            string ss = PassWordUtil.EncryptedInformation(dd);
            Console.WriteLine(ss);
            //string dds = ss.Substring(0, 15);
            //Console.WriteLine(dds);
            Console.WriteLine(ss.Length);
            string ww = PassWordUtil.DecryptInformation(ss);
            Console.WriteLine(ww);
            

            Console.Read();
        }
    }
}
