using FanFormulaFramework.Public;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Until
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
        /// <returns></returns>
        public static string PostPush()
        {

            string url = BaseSystemInfo.ServerUrl + "db/Select";
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("businessKey", "0");
            keyValuePairs.Add("sqlstring", "select top 10 * from CUM_Customer ");
            string resl = Post(url, keyValuePairs);
            if (resl.Length > 0)
            {
                return "22";
            }
            return "11";
        }

        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        private static string Post(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            //req.ContentType = "application/x-www-form-urlencoded";
            req.Headers.Add("Authorization", BaseSystemInfo.ServerRegisterKey);
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
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
