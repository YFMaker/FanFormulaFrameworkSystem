/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : Program
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
using FanFormulaFramework.Util;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework
{
    class Program
    {
        private static IConfiguration Configuration { get; set; }

        /// <summary>
        /// 测试控制台
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.WriteLine(Encoding.GetEncoding("GB2312"));
            Console.WriteLine("Hello World!");
            //Console.WriteLine("!");
            //ILoger<Program> loger = new ILoger<Program>();
            //loger.Information("321321");
            //loger.Error("2222");
            //DataBaseService dataBaseService = new DataBaseService(CurrentDbType.Sqlite, "Data Source=log.db;Pooling=true;FailIfMissing=false");
            //string dd = "";
            //dataBaseService.IsEnable(out dd);
            //Console.WriteLine(dd);
            //for (int i = 1; i < 10; i++)
            //{
            //    LogBase logBase = new LogBase()
            //    {
            //        ID = i.ToString(),
            //        INSETERtIME = "ceshi",
            //        SQLLINQS = "321321321321321321321"
            //    };
            //    dataBaseService.InsterSQL<LogBase>(logBase);
            //}

            //string test = Post("?businessKey=0&sqlstring=select top 10 * from CUM_Customer ");
            //string test = get("key=1");
            string _path = $"Languageenglish.json";// $"config.json";
            string _basepath = System.IO.Directory.GetCurrentDirectory();
            if (!File.Exists(_basepath + _path))
            {
                _basepath = AppContext.BaseDirectory;
                if (!File.Exists(_basepath + _path))
                {
                    DirectoryInfo di = new DirectoryInfo(string.Format("{0}../../../", _basepath));//
                    _basepath = di.FullName;
                }
                if (!File.Exists(_basepath + _path))
                {
                    Console.WriteLine("没有找到配置文件");
                }
            }

            Console.WriteLine(_basepath);
            Configuration = new ConfigurationBuilder()
                 .SetBasePath(_basepath)
               .Add(new JsonConfigurationSource { Path = _path, Optional = false, ReloadOnChange = true })
               .Build();
            //Console.WriteLine(test);

            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-ddHHmmss"));
            //Console.WriteLine(DateTime.Today);
            //BaseSystemInfo.SystemVerion = "111";
            //ILoger loger1 = new ILoger();
            //loger1.Information("222");
            //ConfigurationManagerd configurationManagerd = new ConfigurationManagerd("config.json");
            //string dd = ConfigurationManagerd.Appsetting<string>("DataString", "5556w");
            //loger.Information(dd);
            //ConfigurationManagerd configurationManagerd = new ConfigurationManagerd("appseeting.json");
            //loger.Information(ConfigurationManagerd.Appsetting<bool>("ddddd").ToString());
            //loger.Information(MultiLanguage.NowLanguageString("叁貳壹", "mandarin"));
            //DateTimeUtil.TOString();
            Console.ReadLine();
        }

        public static string get(string str)
        {
            string result = "";

            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            webClient.Headers.Add("Authorization", "Z0TXYdpgyACBXAX");
            string url = "http://192.168.88.128:8081/db/StartDB";
            url = url + "?" + str;
            result=webClient.DownloadString(url);

            return result;
        }

        public static string Post(string str)
        {

            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://192.168.88.129:8081/db/Select");
            req.Method = "POST";
            //req.ContentType = "application/x-www-form-urlencoded";
            req.Headers.Add("Authorization", "gMWACqhGc8np7r2");
            byte[] data = Encoding.UTF8.GetBytes(str);//把字符串转换为字节

            req.ContentLength = data.Length; //请求长度

            using (Stream reqStream = req.GetRequestStream()) //获取
            {
                reqStream.Write(data, 0, data.Length);//向当前流中写入字节
                reqStream.Close(); //关闭当前流
            }

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse(); //响应结果
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
