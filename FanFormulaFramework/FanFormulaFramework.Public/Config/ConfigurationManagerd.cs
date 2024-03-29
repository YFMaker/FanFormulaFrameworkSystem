﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 读取配置工具类
    /// </summary>
    public class ConfigurationManagerd
    {
        private static IConfiguration Configuration { get; set; }
        //static string contentPath { get; set; }

        /// <summary>
        /// 默认本地目录读取指定配置文件
        /// </summary>
        static ConfigurationManagerd()
        {
            //string _environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string _path = BaseSystemInfo.ConfigFile;// $"config.json";

            Configuration = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
               .Add(new JsonConfigurationSource { Path = _path, Optional = false, ReloadOnChange = true })
               .Build();
        }

        /// <summary>
        /// 默认本地目录读取 配置文件
        /// </summary>
        /// <param name="contentPath">配置文件名</param>
        public ConfigurationManagerd(string contentPath)
        {
            //string _environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string _path = contentPath;
            string _basepath = System.IO.Directory.GetCurrentDirectory();
            if (!File.Exists(_basepath + contentPath))
            {
                _basepath= AppContext.BaseDirectory;
                if (!File.Exists(_basepath + contentPath))
                {
                    DirectoryInfo di = new DirectoryInfo(string.Format("{0}../../../", _basepath));//
                    _basepath = di.FullName;
                }
                if (!File.Exists(_basepath + contentPath))
                {
                    ILoger loger = new ILoger();
                    loger.Warning("没有找到配置文件");
                    throw new Exception("没有找到配置文件");
                }
            }
            if (BaseSystemInfo.BaseConfig == "App.config"&& _path!= "App.config")
            {
                _basepath = System.IO.Directory.GetCurrentDirectory();
            }
            if (_path == "App.config")
            {

            }
            else
            {
                Configuration = new ConfigurationBuilder()
                    .SetBasePath(_basepath)
                   .Add(new JsonConfigurationSource { Path = _path, Optional = false, ReloadOnChange = true })
                   .Build();
            }
        }


        /// <summary>
        /// 读取配置信息带默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
        public T Appsetting<T>(string key, T defaultVal)
        {
            try
            {
                return Configuration.GetValue<T>(key, defaultVal);
            }
            catch (Exception ex)
            {
                ILoger loger = new ILoger();
                loger.Warning(ex.Message);
                return defaultVal;
            }
        }

        public static string Appsetting(string key,string defaultVal)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                ILoger loger = new ILoger();
                loger.Warning(ex.Message);
                return defaultVal;
            }
        }

        /// <summary>
        /// 读取配置信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Appsetting<T>(string key)
        {
            try
            {
                return Configuration.GetValue<T>(key);
            }
            catch (Exception ex)
            {
                ILoger loger = new ILoger();
                loger.Warning(ex.Message);
                return default(T);
            }
        }

        /// <summary>
        /// 读取配置信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="defaultvalue"></param>
        /// <param name="tryd"></param>
        /// <returns></returns>
        public static T Appsetting<T>(string key,T defaultvalue,bool tryd=false)
        {
            try
            {
                return Configuration.GetValue<T>(key, defaultvalue);
            }
            catch (Exception ex)
            {
                ILoger loger = new ILoger();
                loger.Warning(ex.Message);
                return defaultvalue;
            }
        }
    }
}
