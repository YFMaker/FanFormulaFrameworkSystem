/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : ILoger
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 控制台打印类
    /// Console print class
    /// </summary>
    /// <typeparam name="T">program/class</typeparam>
    public class ILoger<T>
    {
        public static ILogger logger;
        public ILoger()
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddFilter("FanFormulaFramework", LogLevel.Debug)
                    .AddConsole();
                //.AddEventLog();
            });
            logger = loggerFactory.CreateLogger<T>();
        }

        /// <summary>
        /// 消息打印
        /// </summary>
        /// <param name="message"></param>
        public void Information(string message)
        {
            logger.LogInformation(message);
        }

        /// <summary>
        /// 错误打印
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            logger.LogError(message);
        }

        /// <summary>
        /// 警告打印
        /// </summary>
        /// <param name="message"></param>
        public void Warning(string message)
        {
            logger.LogWarning(message);
        }



    }
}
