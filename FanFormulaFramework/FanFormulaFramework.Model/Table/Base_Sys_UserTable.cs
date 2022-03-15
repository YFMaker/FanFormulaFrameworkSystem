using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Model
{
    /// <summary>
    /// Base_Sys_UserTable
    /// </summary>
    public partial class Base_Sys_UserTable
    {
        ///<summary>
        /// 表名
        ///</summary>
        [NonSerialized]
        public static string TableName = "Base_Sys_User";

        /// <summary>
        /// 业务服务名称
        /// </summary>
        [NonSerialized]
        public static string BusinessName = "";
    }
}
