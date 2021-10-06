using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Util
{
    /// <summary>
    /// 字库处理
    /// </summary>
    public class MultiLanguage
    {
        private static IConfiguration Configuration { get; set; }
        /// <summary>
        /// 字库（逐渐补充）
        /// </summary>
        private static List<string> languagelist = new List<string>() { "mandarin", "traditional", "english" };

        /// <summary>
        /// 输出当前语言字库文字
        /// 若字库无此文字则输出当前文字
        /// </summary>
        /// <param name="value"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public static string NowLanguageString(string value,string language)
        {
            string key = ScanLanguageConfig(value);
            string _path = $"Language{LanguageString(language)}.json";// $"config.json";
            Configuration = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
               .Add(new JsonConfigurationSource { Path = _path, Optional = false, ReloadOnChange = true })
               .Build();
            if (string.IsNullOrEmpty(key))
            {
                return value;
            }
            else if (string.IsNullOrEmpty(Configuration.GetValue<string>(key)))
            {
                return value;
            }
            else
            {
                return Configuration.GetValue<string>(key);
            }
        }
        
        /// <summary>
        /// 语言类型转换语言种类
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        private static string LanguageString(string language)
        {
            string value = string.Empty;
            switch (language)
            {
                case "zh_CN":
                    value = "mandarin";
                    break;
                case "zh-TW":
                    value = "traditional";
                    break;
                case "en-US":
                    value = "english";
                    break;
                default:
                    value = "mandarin";
                    break;
            }

            return value;
        }

        /// <summary>
        /// 扫描字库查找
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        private static string ScanLanguageConfig(string language)
        {
            string key = string.Empty;
            foreach (var item in languagelist)
            {
                string _path = $"Language{item}.json";// $"config.json";
                Configuration = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                   .Add(new JsonConfigurationSource { Path = _path, Optional = false, ReloadOnChange = true })
                   .Build();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                Configuration.Bind(dic);
                foreach (var value in dic)
                {
                    if (value.Value == language)
                    {
                        key = value.Key;
                    }
                }
            }
            return key;
        }
    }
}
