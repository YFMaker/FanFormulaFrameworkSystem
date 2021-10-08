using FanFormulaFramework.DBUtile;
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
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("ShowInformation")))
            {
                BaseSystemInfo.ShowInformation = ConfigurationManagerd.Appsetting<bool>("ShowInformation");
            }
            else
            {
                BaseSystemInfo.ShowInformation = true;
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("StaffServerDbType")))
            {
                BaseSystemInfo.StaffServerDbType = ConfigurationManagerd.Appsetting<CurrentDbType>("StaffServerDbType");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("CustomerServerDbType")))
            {
                BaseSystemInfo.CustomerServerDbType = ConfigurationManagerd.Appsetting<CurrentDbType>("CustomerServerDbType");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("BusinessServerDbType")))
            {
                BaseSystemInfo.BusinessServerDbType = ConfigurationManagerd.Appsetting<CurrentDbType>("BusinessServerDbType");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("MessageServerDbType")))
            {
                BaseSystemInfo.MessageServerDbType = ConfigurationManagerd.Appsetting<CurrentDbType>("MessageServerDbType");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("WorkServerDbType")))
            {
                BaseSystemInfo.WorkServerDbType = ConfigurationManagerd.Appsetting<CurrentDbType>("WorkServerDbType");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("DbConnetEncryptionstring")))
            {
                BaseSystemInfo.DbConnetEncryptionstring = ConfigurationManagerd.Appsetting<bool>("DbConnetEncryptionstring");
            }
            ///数据库连接字符串
            BaseSystemInfo.CustomerServerDbConnetString = ConfigurationManagerd.Appsetting<string>("CustomerServerDbConnetString");
            BaseSystemInfo.BusinessServerDbConnetString = ConfigurationManagerd.Appsetting<string>("BusinessServerDbConnetString");
            BaseSystemInfo.MessageServerDbConnetString = ConfigurationManagerd.Appsetting<string>("MessageServerDbConnetString");
            BaseSystemInfo.WorkServerDbConnetString = ConfigurationManagerd.Appsetting<string>("WorkServerDbConnetString");

            ///用户信息
            BaseSystemInfo.PassWordErrorLockLimt = ConfigurationManagerd.Appsetting<int>("PassWordErrorLockLimt");
            BaseSystemInfo.PassWordErrorLockCycle = ConfigurationManagerd.Appsetting<int>("PassWordErrorLockCycle");
            BaseSystemInfo.MatchCaps = ConfigurationManagerd.Appsetting<bool>("MatchCaps");
            BaseSystemInfo.CheckPassWordStrength = ConfigurationManagerd.Appsetting<bool>("CheckPassWordStrength");
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("ServerEncryptPassWord")))
            {
                BaseSystemInfo.ServerEncryptPassWord = ConfigurationManagerd.Appsetting<bool>("ServerEncryptPassWord");
            }
            BaseSystemInfo.PassWordMiniLength = ConfigurationManagerd.Appsetting<int>("PassWordMiniLength");
            BaseSystemInfo.LetterInPassWord = ConfigurationManagerd.Appsetting < bool>("LetterInPassWord");
            BaseSystemInfo.SystemName = ConfigurationManagerd.Appsetting<string>("SystemName");
        }
    }
}
