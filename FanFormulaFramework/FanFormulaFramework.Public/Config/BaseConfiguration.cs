/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : BaseConfiguration
 CreatUser: YiFan
 Created  : 2021-9-30 08:56:17 
 Summary  : 

 ===============================================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    public class BaseConfiguration
    {
        static BaseConfiguration()
        {
            ConfigurationManagerd configurationManagerd = new ConfigurationManagerd("appsettings.json");
            BaseSystemInfo.ConfigFile = configurationManagerd.Appsetting<string>("ConfigFile", "config.json");
            BaseSystemInfo.ConfigurationCategory = (ConfigurationCategory)configurationManagerd.Appsetting<int>("ConfigurationCategory", 2);
        }

        public static void GetConfig()
        {
            switch (BaseSystemInfo.ConfigurationCategory)
            {
                case ConfigurationCategory.UserConfig:
                    ConfigurationHelper.GetConfig();
                    break;
                case ConfigurationCategory.FileConfiguration:
                    ConfigurationHelper.GetConfig();
                    break;
                case ConfigurationCategory.RegistryConfig:
                    break;
                default:
                    break;
            }
        }

    }
}
