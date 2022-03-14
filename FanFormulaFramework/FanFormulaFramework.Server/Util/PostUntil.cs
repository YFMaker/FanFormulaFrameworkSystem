using FanFormulaFramework.Public;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Server
{
    public class PostUntil
    {

        private static readonly ILoger<PostUntil> Loger;

        static PostUntil()
        {
            Loger = new ILoger<PostUntil>();
        }

        /// <summary>
        /// 请求接口
        /// </summary>
        /// <param name="businessname"></param>
        /// <param name="performtype"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string PostPush(string businessname, string performtype, string content)
        {
            string url = BaseSystemInfo.ServerUrl + "operation/ExecutionBusiness";
            string poststring = "businessname=" + businessname + "&performtype=" + performtype + "&content=" + content;
            string result = string.Empty;
            try
            {
                result = Post(url, poststring);
            }
            catch (Exception ex)
            {
                Loger.Warning(ex.Message);
                return "404";
                //throw;
            }

            return result;
        }

        /// <summary>
        /// 反实例化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                Loger.Warning(ex.Message);
                return default(T);
                //throw;
            }
        }

        private static string Post(string url, string poststring)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            req.Headers.Add("Authorization", BaseSystemInfo.ServerRegisterKey);
            byte[] data = Encoding.UTF8.GetBytes(poststring);//把字符串转换为字节

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

        private static string Get(string url, string getstring)
        {
            string result = "";
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            webClient.Headers.Add("Authorization", BaseSystemInfo.ServerRegisterKey);
            string address = url + "?" + getstring;
            result = webClient.DownloadString(address);
            return result;
        }
    }
}
