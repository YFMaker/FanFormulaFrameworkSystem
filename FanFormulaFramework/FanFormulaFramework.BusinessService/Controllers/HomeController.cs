using FanFormulaFramework.BusinessService.Models;
using FanFormulaFramework.BusinessService.Until;
using FanFormulaFramework.Public;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILoger<HomeController> loger;
        private IHttpClientFactory _httpClient;

        public HomeController(IHttpClientFactory httpClient)
        {
            this.loger = new ILoger<HomeController>();
            this._httpClient = httpClient;
        }

        /// <summary>
        /// 展示数据
        /// </summary>
        [ViewData]
        public InterFaceStateList InterFaces { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [ViewData]
        public string TitleName { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [ViewData]
        public string Message { get; set; }


        public IActionResult Index()
        {
            TitleName = "接口状态";
            SelectIntaceFaceState();
            Message = GetPHtokenAsync().Result;
            return View();
        }

        /// <summary>
        /// 查询接口状态
        /// </summary>
        public void SelectIntaceFaceState()
        {
            //Message = await DoPostRequest(BaseSystemInfo.ServerUrl + "", "222", _httpClient);
        }
        public async Task<dynamic> GetPHtokenAsync()
        {
            try
            {
                dynamic aaa = await DoPostRequest(BaseSystemInfo.ServerUrl + "db/Select", "222", _httpClient);
                return aaa;
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public static async Task<dynamic> DoPostRequest(string Url, string token, IHttpClientFactory httpClient)
        {
            try
            {
                using (var client = httpClient.CreateClient())
                {
                    string responseBody = string.Empty;
                    //var content = new StringContent(parameter, Encoding.UTF8, ContentType);//请求参数   请求消息内容   application/x-www-form-urlencoded "application/json"请求类型
                    client.DefaultRequestHeaders.Add("Method", "Post");
                    var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                   {
                       {"businessKey", "0"},
                       {"sqlstring", "select top 10 * from CUM_Customer "}
                   });
                    if (!string.IsNullOrEmpty(token))
                    {
                        client.DefaultRequestHeaders.Add("Authorization", BaseSystemInfo.ServerRegisterKey); //Bearer认证      如果接口未加密省略此行

                        //var authorizationBased64 = "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes($"{userName}:{password}"));//basic认证方式   用户名:密码 然后base64加密
                        //client.DefaultRequestHeaders.Add("Authorization", authorizationBased64);
                    }
                    content.Headers.Add("ContentType", "application/x-www-form-urlencoded");
                    HttpResponseMessage response = await client.PostAsync(Url, content);
                    //response.EnsureSuccessStatusCode();建议不要使用  一旦相应失败会直接抛出异常   参考官方文档https://docs.microsoft.com/zh-cn/dotnet/api/system.net.http.httpresponsemessage.ensuresuccessstatuscode?redirectedfrom=MSDN&view=net-5.0#System_Net_Http_HttpResponseMessage_EnsureSuccessStatusCode
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        responseBody = response.Content.ReadAsStringAsync().Result;
                        dynamic res = JsonConvert.DeserializeObject<dynamic>(responseBody);
                        return res;
                    }
                    return new { result = "请求异常" };
                }
            }
            catch (Exception e)
            {
                return new { result = "请求异常" };
            }
        }
    }
}
