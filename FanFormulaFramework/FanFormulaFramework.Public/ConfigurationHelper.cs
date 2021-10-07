using FanFormulaFramework.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    public  class ConfigurationHelper
    {
        public static void GetConfig()
        {
            BaseSystemInfo.SystemVerion = ConfigurationManagerd.Appsetting<string>("SystemVerion");
            BaseSystemInfo.SystemCompany = ConfigurationManagerd.Appsetting<string>("SystemCompany");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemInfoValue = ConfigurationManagerd.Appsetting<string>("SystemInfoValue");
            ///注册码
            BaseSystemInfo.SystemRegistrationCode = ConfigurationManagerd.Appsetting<string>("SystemRegistrationCode");
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("SystemDataBaseIsWeighted"))) 
            {
                BaseSystemInfo.SystemDataBaseIsWeighted = ConfigurationManagerd.Appsetting<bool>("SystemDataBaseIsWeighted");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("SystemDataBaseIsWeightedType")))
            {
                BaseSystemInfo.SystemDataBaseIsWeightedType = ConfigurationManagerd.Appsetting<EncryptionType>("SystemDataBaseIsWeightedType");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("HandleIsSave")))
            {
                BaseSystemInfo.HandleIsSave = ConfigurationManagerd.Appsetting<bool>("HandleIsSave");
            }
            else
            {
                BaseSystemInfo.HandleIsSave = true;
            }
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
        }
    }
}
