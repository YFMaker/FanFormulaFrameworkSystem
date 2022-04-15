using FanFormulaFramework.DBUtile;
using FanFormulaFramework.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Library
{
    public class DataUtilLibrary
    {
        private static CurrentDbType DbType;

        /// <summary>
        /// 获取数据库类型
        /// </summary>
        static DataUtilLibrary()
        {
            DbType = BaseSystemInfo.DataBaseType;
        }

        /// <summary>
        /// 制作语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="makeclass"></param>
        /// <param name="type">执行类型</param>
        /// <param name="update">变动参数及值</param>
        /// <param name="wheredate">条件参数及值</param>
        /// <returns></returns>
        public static string MakeSqlstring<T>(T makeclass, MakeType type = MakeType.Inster, Dictionary<string, object> update = null, Dictionary<string, object> wheredate = null)
        {
            string sqlsstring = string.Empty;
            switch (type)
            {
                case MakeType.Inster:
                    sqlsstring=InsterSqlstring<T>(makeclass);
                    break;
                case MakeType.Delete:
                    sqlsstring = DeleteSqlstring<T>(makeclass, wheredate);
                    break;
                case MakeType.Update:
                    sqlsstring = UpdateSqlstring<T>(makeclass, update, wheredate);
                    break;
                case MakeType.Select:
                    sqlsstring = SelectSqlstring<T>(makeclass, wheredate);
                    break;
                default:
                    break;
            }
            return sqlsstring;
        }


        private static string InsterSqlstring<T>(T InsterClass)
        {
            string sqlstring = string.Empty;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    break;
                case CurrentDbType.MySql:
                    sqlstring=DataBaseUtil.ItemToInsterMySqlString<T>(InsterClass);
                    break;
                case CurrentDbType.Oracle:
                    break;
                case CurrentDbType.Sqlite:
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }

            return sqlstring;
        }


        private static string DeleteSqlstring<T>(T DeleteClass,Dictionary<string,object> whereDate)
        {
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    break;
                case CurrentDbType.MySql:
                    break;
                case CurrentDbType.Oracle:
                    break;
                case CurrentDbType.Sqlite:
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }
            return "";
        }


        private static string UpdateSqlstring<T>(T UpdateClass,Dictionary<string,object> upDate,Dictionary<string,object> whereDate)
        {
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    break;
                case CurrentDbType.MySql:
                    break;
                case CurrentDbType.Oracle:
                    break;
                case CurrentDbType.Sqlite:
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }
            return "";
        }
   
        
        private static string SelectSqlstring<T>(T SelectClass,Dictionary<string,object> whereDate)
        {
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    break;
                case CurrentDbType.MySql:
                    break;
                case CurrentDbType.Oracle:
                    break;
                case CurrentDbType.Sqlite:
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }
            return "";
        }
    }
}
