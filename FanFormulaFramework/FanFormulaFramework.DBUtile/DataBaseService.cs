using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Text;

namespace FanFormulaFramework.DBUtile
{
    /// <summary>
    /// DB操作实现类
    /// </summary>
    public class DataBaseService : IDataBaseService
    {
        private readonly CurrentDbType DbType;

        /// <summary>
        /// 默认构造函数
        /// sql语句请注意：
        /// 1.oracle语句结束一定加 ; 否则无法执行。
        /// </summary>
        public DataBaseService()
        {

        }

        /// <summary>
        /// 创建DB连接构造函数
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="DbConnectString">数据库连接字符串</param>
        public DataBaseService(CurrentDbType dbType,string DbConnectString)
        {
            DbType = dbType;
            switch (dbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    sqlserverconnect = new SqlConnection(DbConnectString);
                    break;
                case CurrentDbType.MySql:
                    mysqlconnect = new MySqlConnection(DbConnectString);
                    break;
                case CurrentDbType.Oracle:
                    oracleconnect = new OracleConnection(DbConnectString);
                    break;
                case CurrentDbType.Sqlite:
                    sqliteconnect = new SQLiteConnection(DbConnectString);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 验证数据库连接正常
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        public bool IsEnable(out string Message)
        {
            bool result = false;
            try
            {
                switch (DbType)
                {
                    case CurrentDbType.MicrosoftSQLServer:
                        sqlserverconnect.Open();
                        if (sqlserverconnect.State == ConnectionState.Open)
                        {
                            result = true;
                        }
                        break;
                    case CurrentDbType.MySql:
                        mysqlconnect.Open();
                        if (mysqlconnect.State == ConnectionState.Open)
                        {
                            result = true;
                        }
                        break;
                    case CurrentDbType.Oracle:
                        oracleconnect.Open();
                        if (oracleconnect.State == ConnectionState.Open)
                        {
                            result = true;
                        }
                        break;
                    case CurrentDbType.Sqlite:
                        sqliteconnect.Open();
                        if (sqliteconnect.State == ConnectionState.Open)
                        {
                            result = true;
                        }
                        break;
                    case CurrentDbType.MongoDB:
                        break;
                    case CurrentDbType.Access:
                        break;
                    default:
                        break;
                }
                Message = "数据库展开成功";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                result = false;
            }

            return result;
        }


        #region ///增

        public int InsterSQL(string sql)
        {
            int result = 0;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = InsterSqlServer(sql);
                    break;
                case CurrentDbType.MySql:
                    result = InsterMysql(sql);
                    break;
                case CurrentDbType.Oracle:
                    result = InsterOracle(sql);
                    break;
                case CurrentDbType.Sqlite:
                    result = InsterSqlite(sql);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        public bool InsterSQL<T>(T item)
        {
            bool result = false;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = InsterSqlServer<T>(item);
                    break;
                case CurrentDbType.MySql:
                    result = InsterMysql<T>(item);
                    break;
                case CurrentDbType.Oracle:
                    result = InsterOracle<T>(item);
                    break;
                case CurrentDbType.Sqlite:
                    result = InsterSqlite<T>(item);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public bool InsterSQL<T>(List<T> insterobjectitem, out int insterNum)
        {
            bool result = false;
            insterNum = 0;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = InsterSqlServer<T>(insterobjectitem, out insterNum);
                    break;
                case CurrentDbType.MySql:
                    result = InsterMysql<T>(insterobjectitem, out insterNum);
                    break;
                case CurrentDbType.Oracle:
                    result = InsterOracle<T>(insterobjectitem, out insterNum);
                    break;
                case CurrentDbType.Sqlite:
                    result = InsterSqlite<T>(insterobjectitem, out insterNum);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    insterNum = 0;
                    break;
            }

            return result;
        }

        #endregion

        #region ///删

        public int DeleteSQL(string sql)
        {
            int result = 0;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = DeleteSqlServer(sql);
                    break;
                case CurrentDbType.MySql:
                    result = DeleteMysql(sql);
                    break;
                case CurrentDbType.Oracle:
                    result = DeleteOracle(sql);
                    break;
                case CurrentDbType.Sqlite:
                    result = DeleteSqlite(sql);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        public bool DeleteSQL<T>(string keyword, object Value)
        {
            bool result = false;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = DeleteSqlServer<T>(keyword, Value);
                    break;
                case CurrentDbType.MySql:
                    result = DeleteMysql<T>(keyword, Value);
                    break;
                case CurrentDbType.Oracle:
                    result = DeleteOracle<T>(keyword, Value);
                    break;
                case CurrentDbType.Sqlite:
                    result = DeleteSqlite<T>(keyword, Value);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public bool DeleteSQL<T>(string keyword, List<object> Value)
        {
            bool result = false;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = DeleteSqlServer<T>(keyword, Value);
                    break;
                case CurrentDbType.MySql:
                    result = DeleteMysql<T>(keyword, Value);
                    break;
                case CurrentDbType.Oracle:
                    result = DeleteOracle<T>(keyword, Value);
                    break;
                case CurrentDbType.Sqlite:
                    result = DeleteSqlite<T>(keyword, Value);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public bool DeleteSQL<T>(Dictionary<string, object> keywordvalue)
        {
            bool result = false;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = DeleteSqlServer<T>(keywordvalue);
                    break;
                case CurrentDbType.MySql:
                    result = DeleteMysql<T>(keywordvalue);
                    break;
                case CurrentDbType.Oracle:
                    result = DeleteOracle<T>(keywordvalue);
                    break;
                case CurrentDbType.Sqlite:
                    result = DeleteSqlite<T>(keywordvalue);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        #endregion

        #region ///改

        public int UpdateSQL(string sql)
        {
            int result = 0;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = UpdateSqlServer(sql);
                    break;
                case CurrentDbType.MySql:
                    result = UpdateMysql(sql);
                    break;
                case CurrentDbType.Oracle:
                    result = UpdateOracle(sql);
                    break;
                case CurrentDbType.Sqlite:
                    result = UpdateSqlite(sql);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        public bool UpdateSQL<T>(string keyword, object Value, string editkeyword, object editValue)
        {
            bool result = false;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = UpdateSqlServer<T>(keyword, Value, editkeyword, editValue);
                    break;
                case CurrentDbType.MySql:
                    result = UpdateMysql<T>(keyword, Value, editkeyword, editValue);
                    break;
                case CurrentDbType.Oracle:
                    result = UpdateOracle<T>(keyword, Value, editkeyword, editValue);
                    break;
                case CurrentDbType.Sqlite:
                    result = UpdateSqlite<T>(keyword, Value, editkeyword, editValue);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public bool UpdateSQL<T>(T newItem, string keyword, object Value)
        {
            bool result = false;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = UpdateSqlServer<T>(newItem, keyword, Value);
                    break;
                case CurrentDbType.MySql:
                    result = UpdateMysql<T>(newItem, keyword, Value);
                    break;
                case CurrentDbType.Oracle:
                    result = UpdateOracle<T>(newItem, keyword, Value);
                    break;
                case CurrentDbType.Sqlite:
                    result = UpdateSqlite<T>(newItem, keyword, Value);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public bool UpdateSQL<T>(T newItem, Dictionary<string, object> keywordValue)
        {
            bool result = false;
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = UpdateSqlServer<T>(newItem, keywordValue);
                    break;
                case CurrentDbType.MySql:
                    result = UpdateMysql<T>(newItem, keywordValue);
                    break;
                case CurrentDbType.Oracle:
                    result = UpdateOracle<T>(newItem, keywordValue);
                    break;
                case CurrentDbType.Sqlite:
                    result = UpdateSqlite<T>(newItem, keywordValue);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        #endregion

        #region ///查

        public DataTable SelectSQL(string sql)
        {
            DataTable result = new DataTable();
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = SelectSqlServer(sql);
                    break;
                case CurrentDbType.MySql:
                    result = SelectMysql(sql);
                    break;
                case CurrentDbType.Oracle:
                    result = SelectOracle(sql);
                    break;
                case CurrentDbType.Sqlite:
                    result = SelectSqlite(sql);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        public T SelectSQL<T>(string sql)
        {
            T result = default(T);
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = SelectSqlServer<T>(sql);
                    break;
                case CurrentDbType.MySql:
                    result = SelectMysql<T>(sql);
                    break;
                case CurrentDbType.Oracle:
                    result = SelectOracle<T>(sql);
                    break;
                case CurrentDbType.Sqlite:
                    result = SelectSqlite<T>(sql);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = default(T);
                    break;
            }

            return result;
        }

        public DataTable SelectSQL(string sql, string orderByQuery, int maxpageNum = 10, int pageNum = 0)
        {
            DataTable result = new DataTable();
            switch (DbType)
            {
                case CurrentDbType.MicrosoftSQLServer:
                    result = SelectSqlServer(sql, orderByQuery, maxpageNum, pageNum);
                    break;
                case CurrentDbType.MySql:
                    result = SelectMysql(sql, orderByQuery, maxpageNum, pageNum);
                    break;
                case CurrentDbType.Oracle:
                    result = SelectOracle(sql, orderByQuery, maxpageNum, pageNum);
                    break;
                case CurrentDbType.Sqlite:
                    result = SelectSqlite(sql, orderByQuery, maxpageNum, pageNum);
                    break;
                case CurrentDbType.MongoDB:
                    break;
                case CurrentDbType.Access:
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        #endregion


        #region SQLServer数据库操作

        /// <summary>
        /// SqlServer数据库
        /// </summary>
        private readonly SqlConnection sqlserverconnect;

        #region ///private SelectSqlServer(); 查询SqlServer数据库语句
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        private DataTable SelectSqlServer()
        {
            return null;
        }

        /// <summary>
        /// 根据SQL语句查询返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable SelectSqlServer(string sql)
        {
            DataTable resultTable = new DataTable();
            if (sqlserverconnect.State != ConnectionState.Open)
                sqlserverconnect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlserverconnect);
            sda.Fill(resultTable);
            sqlserverconnect.Close();
            return resultTable;
        }

        /// <summary>
        /// 根据sql语句查询返回实体
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        private T SelectSqlServer<T>(string sql)
        {
            T result = default(T);
            DataTable selecttable = SelectSqlServer(sql);
            if (selecttable.Rows.Count > 0)
            {
                result = DataBaseUtil.GetItem<T>(selecttable.Rows[0]);
            }
            else
            {
                result = default(T);
            }
            return result;
        }

        /// <summary>
        /// SQLServer数据库分页查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="orderBySqlString">排序语句</param>
        /// <param name="maxpageNum">每页最大数量</param>
        /// <param name="pageNum">页数</param>
        /// <returns></returns>
        private DataTable SelectSqlServer(string sql, string orderBySqlString, int maxpageNum = 10, int pageNum = 1)
        {
            StringBuilder sbSql = new StringBuilder(string.Format("SELECT TOP {0} * FROM(", maxpageNum));
            sbSql.AppendFormat(" SELECT ROW_NUMBER () OVER (ORDER BY TMP.{0}) RowNumber ,* FROM ", orderBySqlString);
            sbSql.AppendFormat(" ({0}) as tmp) A ", sql);
            sbSql.AppendFormat(" WHERE A.RowNumber > ({0} - 1) * {1}", pageNum, maxpageNum);
            DataTable result = SelectSqlServer(sbSql.ToString());
            return result;
        }

        #endregion

        #region ///private InsterSqlServer(); 插入SqlServer数据库语句
        /// <summary>
        /// 插入
        /// </summary>
        /// <returns></returns>
        private int InsterSqlServer()
        {
            return 0;
        }

        /// <summary>
        /// 根据SQL语句执行添加返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int InsterSqlServer(string sql)
        {
            try
            {
                if (sqlserverconnect.State != ConnectionState.Open)
                    sqlserverconnect.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlserverconnect);
                int result = cmd.ExecuteNonQuery();
                sqlserverconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据实体执行添加返回是否成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobject"></param>
        /// <returns></returns>
        private bool InsterSqlServer<T>(T insterobject)
        {
            string sql = DataBaseUtil.ItemToInsterSqlServerString<T>(insterobject);
            int executerows = InsterSqlServer(sql);
            if (executerows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据实体数组批量新建（返回成功数量）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobjectItem"></param>
        /// <param name="insterNum"></param>
        /// <returns></returns>
        private bool InsterSqlServer<T>(List<T> insterobjectItem, out int insterNum)
        {
            int listallNum = insterobjectItem.Count;
            insterNum = 0;
            foreach (T item in insterobjectItem)
            {
                string sql = DataBaseUtil.ItemToInsterSqlServerString<T>(item);
                int executerows = InsterSqlServer(sql);
                if (executerows > 0)
                {
                    insterNum++;
                }
            }
            if (listallNum == insterNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region ///private DeleteSqlServer(); 删除SqlServer数据库语句
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        private int DeleteSqlServer()
        {
            return 0;
        }

        /// <summary>
        /// 根据SQL语句执行删除返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int DeleteSqlServer(string sql)
        {
            try
            {
                if (sqlserverconnect.State != ConnectionState.Open)
                    sqlserverconnect.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlserverconnect);
                int result = cmd.ExecuteNonQuery();
                sqlserverconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 单条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        private bool DeleteSqlServer<T>(string keyword, object value)
        {
            string deletesqlstring =
                string.Format("DELETE FORM {0} WHERE {1}='{2}'", typeof(T).Name, keyword, value);
            int result = DeleteSqlServer(deletesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 同条件多条同时删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="value">同关键词下内容数组</param>
        /// <returns></returns>
        private bool DeleteSqlServer<T>(string keyword, List<object> value)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE {1} in (", typeof(T).Name, keyword);
            foreach (var item in value)
            {
                deletessqlstring.AppendFormat("'{0}',", item);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 1, 1);
            deletessqlstring.Append(")");
            int result = DeleteSqlServer(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据单条件字典删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keywordValue">关键词，值</param>
        /// <returns></returns>
        private bool DeleteSqlServer<T>(Dictionary<string, object> keywordValue)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE", typeof(T).Name);
            foreach (var item in keywordValue.Keys)
            {
                deletessqlstring.AppendFormat(" {0}='{1}' AND", item, keywordValue[item]);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 4, 4);
            int result = DeleteSqlServer(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region ///private UpdateSqlServer(); 更改SqlServer数据库语句
        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        private int UpdateSqlServer()
        {
            return 0;
        }

        /// <summary>
        /// 根据SQL语句执行更改返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int UpdateSqlServer(string sql)
        {
            try
            {
                if (sqlserverconnect.State != ConnectionState.Open)
                    sqlserverconnect.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlserverconnect);
                int result = cmd.ExecuteNonQuery();
                sqlserverconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据单条件更改指定字段值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <param name="editkeyword">修改关键字</param>
        /// <param name="editValue">修改值</param>
        /// <returns></returns>
        private bool UpdateSqlServer<T>(string keyword, object Value, string editkeyword, object editValue)
        {
            string updatesqlstring =
                 string.Format("UPDATE {0} SET {1}='{2}' WHERE {3}='{4}'", typeof(T).Name, editkeyword, editValue, keyword, Value);
            int result = UpdateSqlServer(updatesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据新实体单条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <returns></returns>
        private bool UpdateSqlServer<T>(T newItem, string keyword, object Value)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateSqlServerString<T>(newItem));
            updatesqlstring.AppendFormat(" WHERE {0}='{1}'", keyword, Value);
            int result = UpdateSqlServer(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据新实体多条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keywordValue">修改条件关键词，修改条件值</param>
        /// <returns></returns>
        private bool UpdateSqlServer<T>(T newItem, Dictionary<string, object> keywordValue)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateSqlServerString<T>(newItem));
            updatesqlstring.Append(" WHERE");
            foreach (var item in keywordValue.Keys)
            {
                updatesqlstring.AppendFormat(" {0}='{1}' AND", item, keywordValue[item]);
            }
            updatesqlstring.Remove(updatesqlstring.Length - 4, 4);
            int result = UpdateSqlServer(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #endregion


        #region MYsql数据库操作

        /// <summary>
        /// Mysql数据库
        /// </summary>
        private readonly MySqlConnection mysqlconnect;

        #region ///private SelectMysql(); 查询MYsql数据库语句
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        private DataTable SelectMysql()
        {
            return null;
        }
        /// <summary>
        /// 根据sql语句查询返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable SelectMysql(string sql)
        {
            try
            {
                DataTable resultTable = new DataTable();
                if (mysqlconnect.State != ConnectionState.Open)
                    mysqlconnect.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, mysqlconnect);
                sda.Fill(resultTable);
                mysqlconnect.Close();
                return resultTable;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// 根据sql语句查询返回实体
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        private T SelectMysql<T>(string sql)
        {
            T result = default(T);
            DataTable selecttable = SelectMysql(sql);
            if (selecttable.Rows.Count > 0)
            {
                result = DataBaseUtil.GetItem<T>(selecttable.Rows[0]);
            }
            else
            {
                result = default(T);
            }
            return result;
        }

        /// <summary>
        /// 根据sql语句分页查询，返回DataTable列表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="orderByQuery">排序语句</param>
        /// <param name="maxpageNum">每页最大数量</param>
        /// <param name="pageNum">页数</param>
        /// <returns></returns>
        private DataTable SelectMysql(string sql, string orderByQuery, int maxpageNum = 10, int pageNum = 0)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("SELECT * FROM ({0}) as tmp {1}", sql, orderByQuery);
            //sqlBuilder.Append(sql);
            sqlBuilder.AppendFormat(" limit {0},{1} ", pageNum * maxpageNum, maxpageNum);
            DataTable result = SelectMysql(sqlBuilder.ToString());
            return result;
        }

        #endregion

        #region ///private InsterMysql(); 插入MYsql数据库语句
        /// <summary>
        /// 插入
        /// </summary>
        /// <returns></returns>
        private int InsterMysql()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行添加返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int InsterMysql(string sql)
        {
            try
            {
                if (mysqlconnect.State != ConnectionState.Open)
                    mysqlconnect.Open();
                MySqlCommand Mmd = new MySqlCommand(sql, mysqlconnect);
                int result = Mmd.ExecuteNonQuery();
                mysqlconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据实体执行添加返回是否成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobject"></param>
        /// <returns></returns>
        private bool InsterMysql<T>(T insterobject)
        {
            string sql = DataBaseUtil.ItemToInsterMySqlString<T>(insterobject);
            int executerows = InsterMysql(sql);
            if (executerows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据实体数组批量新建（返回成功数量）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobjectitem"></param>
        /// <param name="insterNum">插入成功数量</param>
        /// <returns>是否全部新建成功</returns>
        private bool InsterMysql<T>(List<T> insterobjectitem, out int insterNum)
        {
            int listallNum = insterobjectitem.Count;
            insterNum = 0;
            foreach (T item in insterobjectitem)
            {
                string sql = DataBaseUtil.ItemToInsterMySqlString<T>(item);
                int executerows = InsterMysql(sql);
                if (executerows > 0)
                {
                    insterNum++;
                }
            }
            if (listallNum == insterNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region ///private DeleteMysql(); 删除MYsql数据库语句
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        private int DeleteMysql()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行删除返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int DeleteMysql(string sql)
        {
            try
            {
                if (mysqlconnect.State != ConnectionState.Open)
                    mysqlconnect.Open();
                MySqlCommand Mmd = new MySqlCommand(sql, mysqlconnect);
                int result = Mmd.ExecuteNonQuery();
                mysqlconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 单条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="Value">值</param>
        /// <returns></returns>
        private bool DeleteMysql<T>(string keyword, object Value)
        {
            string deletesqlstring =
                string.Format("DELETE FORM {0} WHERE {1}='{2}'", typeof(T).Name, keyword, Value);
            int result = DeleteMysql(deletesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 同条件多条同时删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="Value">同关键词下内容数组</param>
        /// <returns></returns>
        private bool DeleteMysql<T>(string keyword, List<object> Value)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE {1} in (", typeof(T).Name, keyword);
            foreach (var item in Value)
            {
                deletessqlstring.AppendFormat("'{0}',", item);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 1, 1);
            deletessqlstring.Append(")");
            int result = DeleteMysql(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据单条件字典删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keywordvalue">关键词，值</param>
        /// <returns></returns>
        private bool DeleteMysql<T>(Dictionary<string, object> keywordvalue)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE", typeof(T).Name);
            foreach (var item in keywordvalue.Keys)
            {
                deletessqlstring.AppendFormat(" {0}='{1}' AND", item, keywordvalue[item]);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 4, 4);
            int result = DeleteMysql(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region ///private UpdateMysql(); 更改MYsql数据库语句
        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        private int UpdateMysql()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行更改返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int UpdateMysql(string sql)
        {
            try
            {
                if (mysqlconnect.State != ConnectionState.Open)
                    mysqlconnect.Open();
                MySqlCommand Mmd = new MySqlCommand(sql, mysqlconnect);
                int result = Mmd.ExecuteNonQuery();
                mysqlconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据单条件更改指定字段值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <param name="editkeyword">修改关键字</param>
        /// <param name="editValue">修改值</param>
        /// <returns></returns>
        private bool UpdateMysql<T>(string keyword, object Value, string editkeyword, object editValue)
        {
            string updatesqlstring =
                string.Format("UPDATE {0} SET {1}='{2}' WHERE {3}='{4}'", typeof(T).Name, editkeyword, editValue, keyword, Value);
            int result = UpdateMysql(updatesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据新实体单条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <returns></returns>
        private bool UpdateMysql<T>(T newItem, string keyword, object Value)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateMySqlString<T>(newItem));
            updatesqlstring.AppendFormat(" WHERE {0}='{1}'", keyword, Value);
            int result = UpdateMysql(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据新实体多条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keywordValue">修改条件关键词，修改条件值</param>
        /// <returns></returns>
        private bool UpdateMysql<T>(T newItem, Dictionary<string, object> keywordValue)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateMySqlString<T>(newItem));
            updatesqlstring.Append(" WHERE");
            foreach (var item in keywordValue.Keys)
            {
                updatesqlstring.AppendFormat(" {0}='{1}' AND", item, keywordValue[item]);
            }
            updatesqlstring.Remove(updatesqlstring.Length - 4, 4);
            int result = UpdateMysql(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #endregion


        #region Oracle数据库操作

        /// <summary>
        /// Oracle数据库
        /// </summary>
        private readonly OracleConnection oracleconnect;

        #region ///private SelectOracle(); 查询Oracle数据库语句

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        private DataTable SelectOracle()
        {
            return null;
        }

        /// <summary>
        /// 根据sql语句查询返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable SelectOracle(string sql)
        {
            try
            {
                DataTable resultTable = new DataTable();
                if (oracleconnect.State != ConnectionState.Open)
                    oracleconnect.Open();
                OracleDataAdapter sda = new OracleDataAdapter(sql, oracleconnect);
                sda.Fill(resultTable);
                oracleconnect.Close();
                return resultTable;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// 根据sql语句查询返回实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        private T SelectOracle<T>(string sql)
        {
            T result = default(T);
            DataTable selecttable = SelectOracle(sql);
            if (selecttable.Rows.Count > 0)
            {
                result = DataBaseUtil.GetItem<T>(selecttable.Rows[0]);
            }
            else
            {
                result = default(T);
            }
            return result;
        }

        /// <summary>
        /// 根据sql分页查询，返回DataTable列表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="orderByQuery">排序语句</param>
        /// <param name="maxpageNum">每页最大数据</param>
        /// <param name="pageNum">页数</param>
        /// <returns></returns>
        private DataTable SelectOracle(string sql, string orderByQuery, int maxpageNum = 10, int pageNum = 1)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("SELECT * FROM ({0} {1})", sql, orderByQuery);
            sqlBuilder.AppendFormat(" where rownum between {0} and {1} ", ((pageNum-1) * maxpageNum)+1, (pageNum*maxpageNum));
            DataTable result = SelectOracle(sqlBuilder.ToString());
            return result;
        }

        #endregion

        #region ///private InsterOracle(); 插入Oracle数据库语句

        /// <summary>
        /// 插入
        /// </summary>
        /// <returns></returns>
        private int InsterOracle()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行添加返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int InsterOracle(string sql)
        {
            try
            {
                if (oracleconnect.State != ConnectionState.Open)
                    oracleconnect.Open();
                OracleCommand Omd = new OracleCommand(sql, oracleconnect);
                int result = Omd.ExecuteNonQuery();
                oracleconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据实体执行添加返回是否成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobject"></param>
        /// <returns></returns>
        private bool InsterOracle<T>(T insterobject)
        {
            string sql = DataBaseUtil.ItemToInsterOracleString<T>(insterobject);
            int executerows = InsterOracle(sql);
            if (executerows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据实体数组批量新建（返回成功数量）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobjectitem"></param>
        /// <param name="insterNum"></param>
        /// <returns></returns>
        private bool InsterOracle<T>(List<T> insterobjectitem, out int insterNum)
        {
            int listallNum = insterobjectitem.Count;
            insterNum = 0;
            foreach (T item in insterobjectitem)
            {
                string sql = DataBaseUtil.ItemToInsterOracleString<T>(item);
                int executerows = InsterOracle(sql);
                if (executerows > 0)
                {
                    insterNum++;
                }
            }
            if (listallNum == insterNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region ///private DeleteOracle(); 删除Oracle数据库语句

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        private int DeleteOracle()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行删除返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int DeleteOracle(string sql)
        {
            try
            {
                if (oracleconnect.State != ConnectionState.Open)
                    oracleconnect.Open();
                OracleCommand Omd = new OracleCommand(sql, oracleconnect);
                int result = Omd.ExecuteNonQuery();
                oracleconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 单条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="Value">值</param>
        /// <returns></returns>
        private bool DeleteOracle<T>(string keyword, object Value)
        {
            string deletesqlstring =string.Format("DELETE FORM {0} WHERE {1}='{2}';", typeof(T).Name, keyword, Value);
            int result = DeleteOracle(deletesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 同条件多条同时删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="Value">同关键词下内容数组</param>
        /// <returns></returns>
        private bool DeleteOracle<T>(string keyword, List<object> Value)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE {1} in (", typeof(T).Name, keyword);
            foreach (var item in Value)
            {
                deletessqlstring.AppendFormat("'{0}',", item);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 1, 1);
            deletessqlstring.Append(");");
            int result = DeleteOracle(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据单条件字典删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keywordvalue">关键词，值</param>
        /// <returns></returns>
        private bool DeleteOracle<T>(Dictionary<string, object> keywordvalue)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE", typeof(T).Name);
            foreach (var item in keywordvalue.Keys)
            {
                deletessqlstring.AppendFormat(" {0}='{1}' AND", item, keywordvalue[item]);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 4, 4);
            deletessqlstring.Append(";");
            int result = DeleteOracle(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region ///private UpdateOracle(); 更改Oracle数据库语句

        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        private int UpdateOracle()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行更改返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int UpdateOracle(string sql)
        {
            try
            {
                if (oracleconnect.State != ConnectionState.Open)
                    oracleconnect.Open();
                OracleCommand Omd = new OracleCommand(sql, oracleconnect);
                int result = Omd.ExecuteNonQuery();
                oracleconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据单条件更改指定字段值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <param name="editkeyword">修改关键字</param>
        /// <param name="editValue">修改值</param>
        /// <returns></returns>
        private bool UpdateOracle<T>(string keyword, object Value, string editkeyword, object editValue)
        {
            string updatesqlstring =
                string.Format("UPDATE {0} SET {1}='{2}' WHERE {3}='{4}'", typeof(T).Name, editkeyword, editValue, keyword, Value);
            int result = UpdateOracle(updatesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据新实体单条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <returns></returns>
        private bool UpdateOracle<T>(T newItem, string keyword, object Value)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateOracleString<T>(newItem));
            updatesqlstring.AppendFormat(" WHERE {0}='{1}'", keyword, Value);
            int result = UpdateOracle(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 根据新实体多条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keywordValue">修改条件关键词，修改条件值</param>
        /// <returns></returns>
        private bool UpdateOracle<T>(T newItem, Dictionary<string, object> keywordValue)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateOracleString<T>(newItem));
            updatesqlstring.Append(" WHERE");
            foreach (var item in keywordValue.Keys)
            {
                updatesqlstring.AppendFormat(" {0}='{1}' AND", item, keywordValue[item]);
            }
            updatesqlstring.Remove(updatesqlstring.Length - 4, 4);
            int result = UpdateOracle(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #endregion


        #region Sqlite数据库操作

        /// <summary>
        /// Sqlite数据库
        /// </summary>
        private readonly SQLiteConnection sqliteconnect;

        #region ///private SelectSqlite(); 查询Sqlite数据库语句

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        private DataTable SelectSqlite()
        {
            return null;
        }

        /// <summary>
        /// 根据sql语句查询返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable SelectSqlite(string sql)
        {
            try
            {
                DataTable resultTable = new DataTable();
                if (sqliteconnect.State != ConnectionState.Open)
                    sqliteconnect.Open();
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, sqliteconnect);
                sda.Fill(resultTable);
                sqliteconnect.Close();
                return resultTable;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// 根据sql语句查询返回实体
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        private T SelectSqlite<T>(string sql)
        {
            T result = default(T);
            DataTable selecttable = SelectSqlite(sql);
            if (selecttable.Rows.Count > 0)
            {
                result = DataBaseUtil.GetItem<T>(selecttable.Rows[0]);
            }
            else
            {
                result = default(T);
            }
            return result;
        }

        /// <summary>
        /// 根据sql语句分页查询，返回DataTable列表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="orderByQuery">排序语句</param>
        /// <param name="maxpageNum">每页最大数量</param>
        /// <param name="pageNum">页数</param>
        /// <returns></returns>
        private DataTable SelectSqlite(string sql, string orderByQuery, int maxpageNum = 10, int pageNum = 0)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("SELECT * FROM ({0}) as tmp {1}", sql, orderByQuery);
            sqlBuilder.Append(sql);
            sqlBuilder.AppendFormat(" limit {0},{1} ", pageNum * maxpageNum, maxpageNum);
            DataTable result = SelectSqlite(sqlBuilder.ToString());
            return result;
        }

        #endregion

        #region ///private InsterSqlite(); 插入Sqlite数据库语句

        /// <summary>
        /// 插入
        /// </summary>
        /// <returns></returns>
        private int InsterSqlite()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行添加返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int InsterSqlite(string sql)
        {
            try
            {
                if (sqliteconnect.State != ConnectionState.Open)
                    sqliteconnect.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, sqliteconnect);
                int result = cmd.ExecuteNonQuery();
                sqliteconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据实体执行添加返回是否成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobject"></param>
        /// <returns></returns>
        private bool InsterSqlite<T>(T insterobject)
        {
            string sql = DataBaseUtil.ItemToInsterSQLiteString<T>(insterobject);
            int executerows = InsterSqlite(sql);
            if (executerows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据实体数组批量新建（返回成功数量）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insterobjectitem"></param>
        /// <param name="insterNum">插入成功数量</param>
        /// <returns>是否全部新建成功</returns>
        private bool InsterSqlite<T>(List<T> insterobjectitem, out int insterNum)
        {
            int listallNum = insterobjectitem.Count;
            insterNum = 0;
            foreach (T item in insterobjectitem)
            {
                string sql = DataBaseUtil.ItemToInsterSQLiteString<T>(item);
                int executerows = InsterSqlite(sql);
                if (executerows > 0)
                {
                    insterNum++;
                }
            }
            if (listallNum == insterNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region ///private DeleteSqlite(); 删除Sqlite数据库语句

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        private int DeleteSqlite()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行删除返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int DeleteSqlite(string sql)
        {
            try
            {
                if (sqliteconnect.State != ConnectionState.Open)
                    sqliteconnect.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, sqliteconnect);
                int result = cmd.ExecuteNonQuery();
                sqliteconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 单条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="Value">值</param>
        /// <returns></returns>
        private bool DeleteSqlite<T>(string keyword, object Value)
        {
            string deletesqlstring =
                string.Format("DELETE FORM {0} WHERE {1}='{2}'", typeof(T).Name, keyword, Value);
            int result = DeleteSqlite(deletesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 同条件多条同时删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">关键词</param>
        /// <param name="Value">同关键词下内容数组</param>
        /// <returns></returns>
        private bool DeleteSqlite<T>(string keyword, List<object> Value)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE {1} in (", typeof(T).Name, keyword);
            foreach (var item in Value)
            {
                deletessqlstring.AppendFormat("'{0}',", item);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 1, 1);
            deletessqlstring.Append(")");
            int result = DeleteSqlite(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据单条件字典删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keywordvalue">关键词，值</param>
        /// <returns></returns>
        private bool DeleteSqlite<T>(Dictionary<string, object> keywordvalue)
        {
            StringBuilder deletessqlstring = new StringBuilder();
            deletessqlstring.AppendFormat("DELETE FROM {0} WHERE", typeof(T).Name);
            foreach (var item in keywordvalue.Keys)
            {
                deletessqlstring.AppendFormat(" {0}='{1}' AND", item, keywordvalue[item]);
            }
            deletessqlstring.Remove(deletessqlstring.Length - 4, 4);
            int result = DeleteSqlite(deletessqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region ///private UpdateSqlite(); 更改Sqlite数据库语句

        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        private int UpdateSqlite()
        {
            return 0;
        }

        /// <summary>
        /// 根据sql语句执行更改返回被影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private int UpdateSqlite(string sql)
        {
            try
            {
                if (sqliteconnect.State != ConnectionState.Open)
                    sqliteconnect.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, sqliteconnect);
                int result = cmd.ExecuteNonQuery();
                sqliteconnect.Close();
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// 根据单条件更改指定字段值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <param name="editkeyword">修改关键字</param>
        /// <param name="editValue">修改值</param>
        /// <returns></returns>
        private bool UpdateSqlite<T>(string keyword, object Value, string editkeyword, object editValue)
        {
            string updatesqlstring =
                string.Format("UPDATE {0} SET {1}='{2}' WHERE {3}='{4}'", typeof(T).Name, editkeyword, editValue, keyword, Value);
            int result = UpdateSqlite(updatesqlstring);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据新实体单条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keyword">修改条件关键字</param>
        /// <param name="Value">修改条件值</param>
        /// <returns></returns>
        private bool UpdateSqlite<T>(T newItem, string keyword, object Value)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateSQLiteString<T>(newItem));
            updatesqlstring.AppendFormat(" WHERE {0}='{1}'", keyword, Value);
            int result = UpdateSqlite(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据新实体多条件更改指定表数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newItem">新实体</param>
        /// <param name="keywordValue">修改条件关键词，修改条件值</param>
        /// <returns></returns>
        private bool UpdateSqlite<T>(T newItem, Dictionary<string, object> keywordValue)
        {
            StringBuilder updatesqlstring = new StringBuilder();
            updatesqlstring.Append(DataBaseUtil.ItemToUpdateSQLiteString<T>(newItem));
            updatesqlstring.Append(" WHERE");
            foreach (var item in keywordValue.Keys)
            {
                updatesqlstring.AppendFormat(" {0}='{1}' AND", item, keywordValue[item]);
            }
            updatesqlstring.Remove(updatesqlstring.Length - 4, 4);
            int result = UpdateSqlite(updatesqlstring.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #endregion


        #region MongoDB

        ///TODO 需求使用较少不做兼容执行

        #endregion
    }
}
