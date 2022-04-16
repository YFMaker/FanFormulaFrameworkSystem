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
        public static string MakeSqlstring<T>(T makeclass, MakeType type = MakeType.Inster, Dictionary<string, object> wheredate = null)
        {
            string sqlsstring = string.Empty;
            switch (type)
            {
                case MakeType.Inster:
                    sqlsstring = InsterSqlstring<T>(makeclass);
                    break;
                case MakeType.Delete:
                    sqlsstring = DeleteSqlstring<T>(makeclass, wheredate);
                    break;
                case MakeType.Update:
                    sqlsstring = UpdateSqlstring<T>(makeclass, wheredate);
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
                    sqlstring = DataBaseUtil.ItemToInsterSqlServerString<T>(InsterClass);
                    break;
                case CurrentDbType.MySql:
                    sqlstring = DataBaseUtil.ItemToInsterMySqlString<T>(InsterClass);
                    break;
                case CurrentDbType.Oracle:
                    sqlstring = DataBaseUtil.ItemToInsterOracleString<T>(InsterClass);
                    break;
                case CurrentDbType.Sqlite:
                    sqlstring = DataBaseUtil.ItemToInsterSQLiteString<T>(InsterClass);
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


        private static string DeleteSqlstring<T>(T DeleteClass, Dictionary<string, object> whereDate)
        {
            StringBuilder sqlstring = new StringBuilder();
            string Tablename = typeof(T).Name;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    sqlstring.AppendFormat("delete FROM  {0} where 1=1 ", Tablename);
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.MySql:
                    sqlstring.AppendFormat("delete FROM {0} where 1=1 ", Tablename);
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.Oracle:
                    sqlstring.AppendFormat("delete FROM {0} where 1=1 ", Tablename);
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.Sqlite:
                    sqlstring.AppendFormat("delete FROM {0} where 1=1 ", Tablename);
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }
            return sqlstring.ToString();
        }


        private static string UpdateSqlstring<T>(T UpdateClass, Dictionary<string, object> whereDate)
        {
            StringBuilder sqlstring = new StringBuilder();
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    sqlstring.Append(DataBaseUtil.ItemToUpdateSqlServerString<T>(UpdateClass));
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.MySql:
                    sqlstring.Append(DataBaseUtil.ItemToUpdateMySqlString<T>(UpdateClass));
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.Oracle:
                    sqlstring.Append(DataBaseUtil.ItemToUpdateOracleString<T>(UpdateClass));
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.Sqlite:
                    sqlstring.Append(DataBaseUtil.ItemToUpdateSQLiteString<T>(UpdateClass));
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }
            return sqlstring.ToString();
        }


        private static string SelectSqlstring<T>(T SelectClass, Dictionary<string, object> whereDate)
        {
            StringBuilder sqlstring = new StringBuilder();
            string Tablebname = typeof(T).Name;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    sqlstring.AppendFormat("select * from {0}", Tablebname);
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.MySql:
                    sqlstring.AppendFormat("select * from {0}", Tablebname);
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.Oracle:
                    sqlstring.AppendFormat("select * from {0}", Tablebname);
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.Sqlite:
                    sqlstring.AppendFormat("select * from {0}", Tablebname);
                    sqlstring.Append(" where 1=1 ");
                    foreach (var item in whereDate.Keys)
                    {
                        string sqlwhere = string.Empty;
                        if (whereDate[item].GetType().Name == "string")
                        {
                            sqlwhere = string.Format(" and {0}='{1}'", item, whereDate[item].ToString());
                        }
                        else if (whereDate[item].GetType().Name == "int")
                        {
                            sqlwhere = string.Format(" and {0}={1}", item, whereDate[item].ToString());
                        }
                        sqlstring.Append(sqlwhere);
                    }
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }
            return sqlstring.ToString();
        }
    }
}
