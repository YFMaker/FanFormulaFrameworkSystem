using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    public  class ConfigurationHelper
    {
        static ConfigurationHelper()
        {
            ConfigurationManagerd configurationManagerd = new ConfigurationManagerd(BaseSystemInfo.ConfigFile);
        }

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

            ///组织结构



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
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("ChangePassWordTime")))
            {
                BaseSystemInfo.ChangePassWordTime = ConfigurationManagerd.Appsetting<int>("ChangePassWordTime");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("AccountNameMiniLength")))
            {
                BaseSystemInfo.AccountNameMiniLength = ConfigurationManagerd.Appsetting<int>("AccountNameMiniLength");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("PassWordEncryptionKey")))
            {
                BaseSystemInfo.PassWordEncryptionKey = ConfigurationManagerd.Appsetting<string>("PassWordEncryptionKey");
            }

            ///服务信息
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("Host")))
            {
                BaseSystemInfo.Host = ConfigurationManagerd.Appsetting<string>("Host");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("Port")))///默认8988
            {
                BaseSystemInfo.Port = ConfigurationManagerd.Appsetting<int>("Port");
            }
            BaseSystemInfo.NewUserRegister = ConfigurationManagerd.Appsetting<bool>("NewUserRegister");
            BaseSystemInfo.UserOnLineLock = ConfigurationManagerd.Appsetting<bool>("UserOnLineLock");
            BaseSystemInfo.NeedRegister = ConfigurationManagerd.Appsetting<bool>("NeedRegister",true);
            BaseSystemInfo.ServerRegisterKey = ConfigurationManagerd.Appsetting<string>("ServerRegisterKey");
            BaseSystemInfo.ServerCache = ConfigurationManagerd.Appsetting<bool>("ServerCache",false);
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");
            BaseSystemInfo.OnLineTimeOut = ConfigurationManagerd.Appsetting<int>("OnLineTimeOut",5*60+40);
            BaseSystemInfo.OnLineCheck = ConfigurationManagerd.Appsetting<int>("OnLineCheck",1*60);
            BaseSystemInfo.LockNoWaitCount = ConfigurationManagerd.Appsetting<int>("LockNoWaitCount");
            BaseSystemInfo.LockNoWaitTickTime = ConfigurationManagerd.Appsetting<int>("LockNoWaitTickTime");
            BaseSystemInfo.UploadDirectory = ConfigurationManagerd.Appsetting<string>("UploadDirectory");
            BaseSystemInfo.DefaultPassWord = ConfigurationManagerd.Appsetting<string>("DefaultPassWord");
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");
            BaseSystemInfo.SystemCode = ConfigurationManagerd.Appsetting<string>("SystemCode");


        }
    }
}
