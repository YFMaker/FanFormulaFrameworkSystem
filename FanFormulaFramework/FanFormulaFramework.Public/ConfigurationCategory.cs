/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : ConfigurationCategory
 CreatUser: YiFan
 Created  : 2021-9-30 08:56:17 
 Summary  : 

 ===============================================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.Public
{
    /// <summary>
    /// 系统配置信息读取
    /// <create>
    ///    衣凡
    /// </create>
    /// <createDatetime>
    /// 2021-9-30 08:57:43
    /// </createDatetime>
    /// </summary>
    public enum ConfigurationCategory
    {
        /// <summary>
        /// 用户的配置文件
        /// </summary>
        UserConfig = 1,
        /// <summary>
        /// 配置文件
        /// </summary>
        FileConfiguration = 2,
        /// <summary>
        /// 注册表
        /// </summary>
        RegistryConfig = 3
    }
}
