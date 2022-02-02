using FanFormulaFramework.Public;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Until
{
    /// <summary>
    /// 请求类
    /// </summary>
    public class PostUntil
    {

        private static readonly ILoger<PostUntil> Loger;

        static PostUntil()
        {
            Loger = new ILoger<PostUntil>();
        }

        /// <summary>
        /// 请求接口(定向专用)
        /// </summary>
        /// <returns></returns>
        public static string PostPush(string typename,int businesskey,string sqlstring)
        {
            string url = BaseSystemInfo.ServerUrl + "db/" + typename;
            string poststring = "businessKey=" + businesskey + "&sqlstring=" + sqlstring;
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
            return JsonConvert.DeserializeObject<T>(json);
        }

        private static string Post(string url,string poststring)
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
    }
}
