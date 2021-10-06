/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : ILoger
 CreatUser: YiFan
 Created  : 2021-9-29 08:38:00 
 Summary  : 

 ===============================================================================================*/
using FanFormulaFramework.Util;
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
            logger.LogInformation(MultiLanguage.NowLanguageString(message, BaseSystemInfo.CurrentLanguage));
        }

        /// <summary>
        /// 错误打印
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            logger.LogError(MultiLanguage.NowLanguageString(message, BaseSystemInfo.CurrentLanguage));
        }

        /// <summary>
        /// 警告打印
        /// </summary>
        /// <param name="message"></param>
        public void Warning(string message)
        {
            logger.LogWarning(MultiLanguage.NowLanguageString(message, BaseSystemInfo.CurrentLanguage));
        }



    }

    /// <summary>
    /// 控制台打印类(无对应程序集，用于基类打印事件)
    /// Console print class
    /// </summary>
    public class ILoger
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
            logger = loggerFactory.CreateLogger(this.GetType());
        }

        /// <summary>
        /// 消息打印
        /// </summary>
        /// <param name="message"></param>
        public void Information(string message)
        {
            logger.LogInformation(MultiLanguage.NowLanguageString(message, BaseSystemInfo.CurrentLanguage));
        }

        /// <summary>
        /// 错误打印
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            logger.LogError(MultiLanguage.NowLanguageString(message, BaseSystemInfo.CurrentLanguage));
        }

        /// <summary>
        /// 警告打印
        /// </summary>
        /// <param name="message"></param>
        public void Warning(string message)
        {
            logger.LogWarning(MultiLanguage.NowLanguageString(message, BaseSystemInfo.CurrentLanguage));
        }
    }
}
