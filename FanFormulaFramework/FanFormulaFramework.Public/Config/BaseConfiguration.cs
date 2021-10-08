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
            ConfigurationManagerd configurationManagerd = new ConfigurationManagerd("Appsetting.json");
            BaseSystemInfo.ConfigurationCategory = (ConfigurationCategory)configurationManagerd.Appsetting<int>("ConfigurationCategory", 2);
        }

        public static void GetConfig()
        {
            switch (BaseSystemInfo.ConfigurationCategory)
            {
                case ConfigurationCategory.UserConfig:
                    break;
                case ConfigurationCategory.FileConfiguration:
                    break;
                case ConfigurationCategory.RegistryConfig:
                    break;
                default:
                    break;
            }
        }

    }
}
