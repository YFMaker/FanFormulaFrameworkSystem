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
            #region 基础信息
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
            BaseSystemInfo.StaffServerDbConnetString= ConfigurationManagerd.Appsetting<string>("StaffServerDbConnetString");
            BaseSystemInfo.CustomerServerDbConnetString = ConfigurationManagerd.Appsetting<string>("CustomerServerDbConnetString");
            BaseSystemInfo.BusinessServerDbConnetString = ConfigurationManagerd.Appsetting<string>("BusinessServerDbConnetString");
            BaseSystemInfo.MessageServerDbConnetString = ConfigurationManagerd.Appsetting<string>("MessageServerDbConnetString");
            BaseSystemInfo.WorkServerDbConnetString = ConfigurationManagerd.Appsetting<string>("WorkServerDbConnetString");
            #endregion
            #region 组织结构
            BaseSystemInfo.UseRoleOrganize = ConfigurationManagerd.Appsetting<bool>("UseRoleOrganize",false);
            BaseSystemInfo.UsePermissionScope = ConfigurationManagerd.Appsetting<bool>("UsePermissionScope", true);
            BaseSystemInfo.UseAuthorizationScope = ConfigurationManagerd.Appsetting<bool>("UseAuthorizationScope", false);
            BaseSystemInfo.UseUserPermission = ConfigurationManagerd.Appsetting<bool>("UseUserPermission", true);
            BaseSystemInfo.UseOrganizePermission = ConfigurationManagerd.Appsetting<bool>("UseOrganizePermission", false);
            BaseSystemInfo.UseTableScopePermission = ConfigurationManagerd.Appsetting<bool>("UseTableScopePermission", false);
            BaseSystemInfo.UseTableColumnPermission = ConfigurationManagerd.Appsetting<bool>("UseTableColumnPermission", false);
            BaseSystemInfo.HandwrittenSignature = ConfigurationManagerd.Appsetting<bool>("HandwrittenSignature", false);
            BaseSystemInfo.RecordLogOnLog = ConfigurationManagerd.Appsetting<bool>("RecordLogOnLog", true);
            BaseSystemInfo.RecordLog = ConfigurationManagerd.Appsetting<bool>("RecordLog", true);
            BaseSystemInfo.UpdateVisit = ConfigurationManagerd.Appsetting<bool>("UpdateVisit", true);
            BaseSystemInfo.OnLineLimit = ConfigurationManagerd.Appsetting<int>("OnLineLimit", 0);
            BaseSystemInfo.CheckIPAddress = ConfigurationManagerd.Appsetting<bool>("CheckIPAddress", false);
            BaseSystemInfo.LogException = ConfigurationManagerd.Appsetting<bool>("LogException", true);
            BaseSystemInfo.LogSQL = ConfigurationManagerd.Appsetting<bool>("LogSQL", true);
            BaseSystemInfo.EventLog = ConfigurationManagerd.Appsetting<bool>("EventLog", false);
            #endregion
            #region 用户信息
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
            #endregion
            #region 服务端信息
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("Host")))
            {
                BaseSystemInfo.Host = ConfigurationManagerd.Appsetting<string>("Host");
            }
            if (!string.IsNullOrEmpty(ConfigurationManagerd.Appsetting<string>("Port")))///默认8988
            {
                BaseSystemInfo.Port = ConfigurationManagerd.Appsetting<int>("Port");
            }
            BaseSystemInfo.DataBaseType = ConfigurationManagerd.Appsetting<CurrentDbType>("DataBaseType");
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
            #endregion
            #region 客户端信息
            BaseSystemInfo.MainForm = ConfigurationManagerd.Appsetting<string>("MainForm", "FrmFanFormulaMain");
            BaseSystemInfo.LogOnForm = ConfigurationManagerd.Appsetting<string>("LogOnForm", "FrmLogOn");
            BaseSystemInfo.CookieExpires = ConfigurationManagerd.Appsetting<int>("CookieExpires", 30);
            BaseSystemInfo.UseMessge = ConfigurationManagerd.Appsetting<bool>("UseMessge", true);
            BaseSystemInfo.CurrentCompany = ConfigurationManagerd.Appsetting<string>("CurrentCompany");
            BaseSystemInfo.CurrentUserName = ConfigurationManagerd.Appsetting<string>("CurrentUserName");
            BaseSystemInfo.CurrentPassWord = ConfigurationManagerd.Appsetting<string>("CurrentPassWord");
            BaseSystemInfo.RemendPassWord = ConfigurationManagerd.Appsetting<bool>("RemendPassWord", true);
            BaseSystemInfo.AutoLogOn = ConfigurationManagerd.Appsetting<bool>("AutoLogOn", false);
            BaseSystemInfo.ClientEncryptionPassWord = ConfigurationManagerd.Appsetting<bool>("ClientEncryptionPassWord", true);
            BaseSystemInfo.OrganizeDynamicLoading = ConfigurationManagerd.Appsetting<bool>("OrganizeDynamicLoading", true);
            BaseSystemInfo.Multilingual = ConfigurationManagerd.Appsetting<bool>("Multilingual", true);
            BaseSystemInfo.CurrentLanguage = ConfigurationManagerd.Appsetting<string>("CurrentLanguage", "zh-CN");
            BaseSystemInfo.Themes = ConfigurationManagerd.Appsetting<string>("Themes");
            BaseSystemInfo.ClientCache = ConfigurationManagerd.Appsetting<bool>("ClientCache", false);
            BaseSystemInfo.MessageWebHostUrl = ConfigurationManagerd.Appsetting<string>("MessageWebHostUrl");
            BaseSystemInfo.MainAssembly = ConfigurationManagerd.Appsetting<string>("MainAssembly", "FanFormulaFramework");
            BaseSystemInfo.ServerUrl = ConfigurationManagerd.Appsetting<string>("ServerUrl");
            #endregion
        }
    }
}
