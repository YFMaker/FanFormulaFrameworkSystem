using FanFormulaFramework.Public;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService
{
    public class Program
    {
        private static string HostUrl = string.Empty;
        public static void Main(string[] args)
        {
            BaseConfiguration.GetConfig();
            HostUrl = "http://" + BaseSystemInfo.Host + ":" + BaseSystemInfo.Port;
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseUrls(HostUrl)
            .ConfigureAppConfiguration((hostingContext, config) =>
                   {
                       config.AddJsonFile("appsettings.json",
                           optional: true,
                           reloadOnChange: false);
                       //config.AddJsonFile($"appsettings.{environmentName}.json", true, false);
                   })
                .UseStartup<Startup>();
    }
}
