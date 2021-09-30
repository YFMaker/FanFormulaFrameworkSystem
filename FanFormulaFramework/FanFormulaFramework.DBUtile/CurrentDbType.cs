/*===============================================================================================

 Copyright© 2021 YiFan Ltd. All rights reserved.
 
 Author   : CurrentDbType
 CreatUser: YiFan
 Created  : 2021-9-30 16:12:57
 Summary  : 

 ===============================================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.DBUtile
{
    public enum CurrentDbType
    {
        /// <summary>
        /// SQL
        /// </summary>
        MicrosoftSQLServer=1,
        /// <summary>
        /// MYSQL
        /// </summary>
        MySql=2,
        /// <summary>
        /// SQLite
        /// </summary>
        Sqlite=3,
        /// <summary>
        /// MongDb
        /// </summary>
        MongDB=4,
        /// <summary>
        /// Access
        /// </summary>
        Access=5
    }
}
