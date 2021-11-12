using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace FanFormulaFramework.DBUtile
{
    /// <summary>
    /// DB服务操作工具类
    /// </summary>
    public static class DataBaseUtil
    {

        /// <summary>
        /// 将DataTable转实体列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> GetItemList<T>(DataTable dt)
        {
            List<T> result = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// 将DataRow转换成实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static T GetItem<T>(DataRow dr)
        {
            try
            {
                Type temp = typeof(T);
                T obj = Activator.CreateInstance<T>();
                foreach (DataColumn column in dr.Table.Columns)
                {
                    foreach (PropertyInfo pro in temp.GetProperties())
                    {
                        if (pro.Name.ToLower() == column.ColumnName.ToLower())
                        {
                            if (dr[column.ColumnName] == DBNull.Value)
                            {
                                pro.SetValue(obj, " ", null);
                                break;
                            }
                            else
                            {
                                pro.SetValue(obj, dr[column.ColumnName], null);
                                break;
                            }
                        }
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        #region SQLServer语句生成辅助

        /// <summary>
        /// SQLServer实体转插入语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToInsterSqlServerString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            sqlstringBuilder.AppendFormat("insert into {0} (", typeof(T).Name);
            foreach (PropertyInfo prop in props)
            {
                sqlstringBuilder.AppendFormat(@"{0},", prop.Name);
            }
            sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1);
            sqlstringBuilder.Append(" ) values (");
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (t == typeof(string) || t == typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat(@" '{0}',", vaule);
                }
                else
                {
                    sqlstringBuilder.AppendFormat(@" {0},", vaule);
                }
                i++;
            }
            sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1);
            sqlstringBuilder.Append(")");
            return sqlstringBuilder.ToString();
        }

        /// <summary>
        /// SQLServer实体转更改语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToUpdateSqlServerString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            sqlstringBuilder.AppendFormat("UPDATE {0} set", typeof(T).Name);
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (t == typeof(string) || t == typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat(@" {0}='{1}',", prop.Name, vaule);
                }
                else
                {
                    sqlstringBuilder.AppendFormat(@" {0}={1},", prop.Name, vaule);
                }
                i++;
            }
            return sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1).ToString();
        }

        #endregion

        #region Mysql语句生成辅助

        /// <summary>
        /// Mysql实体转插入语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToInsterMySqlString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            sqlstringBuilder.AppendFormat("insert into {0} set", typeof(T).Name);
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (t == typeof(string) || t == typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat(@" {0}='{1}',", prop.Name, vaule);
                }
                else
                {
                    sqlstringBuilder.AppendFormat(@" {0}={1},", prop.Name, vaule);
                }
                i++;
            }
            return sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1).ToString();
        }

        /// <summary>
        /// Mysql实体转更改语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToUpdateMySqlString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            sqlstringBuilder.AppendFormat("UPDATE {0} set", typeof(T).Name);
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (t == typeof(string) || t == typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat(@" {0}='{1}',", prop.Name, vaule);
                }
                else
                {
                    sqlstringBuilder.AppendFormat(@" {0}={1},", prop.Name, vaule);
                }
                i++;
            }
            return sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1).ToString();
        }

        #endregion

        #region Oracle语句生成辅助

        /// <summary>
        /// Oracle实体转插入语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToInsterOracleString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            sqlstringBuilder.AppendFormat("insert into {0} ", typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            List<string> ItemKey = new List<string>();
            List<oracleInster> ItemValue = new List<oracleInster>();
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (vaule != null)//未赋值字段不做处理
                {
                    ItemKey.Add(prop.Name);//记录类变量
                    ItemValue.Add(new oracleInster() { TypeName=t,Value=vaule});//记录类变量值
                }
                i++;
            }
            sqlstringBuilder.Append("(");
            for (int listnum = 0; listnum < ItemKey.Count; listnum++)
            {
                sqlstringBuilder.AppendFormat("{0},",ItemKey[listnum]);
            }
            sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1);
            sqlstringBuilder.Append(") values (");
            for (int listnum = 0; listnum < ItemValue.Count; listnum++)
            {
                oracleInster Value = ItemValue[listnum];
                if(Value.TypeName == typeof(string))
                {
                    sqlstringBuilder.AppendFormat(" '{0}',",Value.Value);
                }
                else if(Value.TypeName== typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat("DATE '{0}',", Value.Value);
                }
                else
                {
                    sqlstringBuilder.AppendFormat("{0},", Value.Value);
                }
            }
            sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1);
            sqlstringBuilder.Append(");");
            return sqlstringBuilder.ToString();
        }

        /// <summary>
        /// Oracle实体转更改语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToUpdateOracleString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            sqlstringBuilder.AppendFormat("UPDATE {0} set", typeof(T).Name);
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (t == typeof(string))
                {
                    sqlstringBuilder.AppendFormat(" {0}='{1}',", prop.Name, vaule);
                }
                else if (t == typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat(" {0}=DATE '{1}',", prop.Name, vaule);
                }
                else
                {
                    sqlstringBuilder.AppendFormat(" {0}={1},", prop.Name, vaule);
                }
                i++;
            }
            return sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1).ToString();
        }

        /// <summary>
        /// oracle 语句处理时内容类
        /// </summary>
        class oracleInster
        {
            /// <summary>
            /// 字段类型
            /// </summary>
            public Type TypeName { get; set; }

            /// <summary>
            /// 字段值
            /// </summary>
            public object Value { get; set; }
        }


        #endregion

        #region SQLite语句生成辅助

        /// <summary>
        /// SQLite实体转插入语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToInsterSQLiteString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            sqlstringBuilder.AppendFormat("insert into {0} ", typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            List<string> ItemKey = new List<string>();
            List<sqliteInster> ItemValue = new List<sqliteInster>();
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (vaule != null)//未赋值字段不做处理
                {
                    ItemKey.Add(prop.Name);//记录类变量
                    ItemValue.Add(new sqliteInster() { TypeName = t, Value = vaule });//记录类变量值
                }
                i++;
            }
            sqlstringBuilder.Append("(");
            for (int listnum = 0; listnum < ItemKey.Count; listnum++)
            {
                sqlstringBuilder.AppendFormat("{0},", ItemKey[listnum]);
            }
            sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1);
            sqlstringBuilder.Append(") values (");
            for (int listnum = 0; listnum < ItemValue.Count; listnum++)
            {
                sqliteInster Value = ItemValue[listnum];
                if (Value.TypeName == typeof(string))
                {
                    sqlstringBuilder.AppendFormat(" '{0}',", Value.Value);
                }
                else if (Value.TypeName == typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat(" datetime(‘{0}’),", Value.Value);
                }
                else
                {
                    sqlstringBuilder.AppendFormat("{0},", Value.Value);
                }
            }
            sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1);
            sqlstringBuilder.Append(");");
            return sqlstringBuilder.ToString();
        }

        /// <summary>
        /// Oracle实体转更改语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ItemToUpdateSQLiteString<T>(T item)
        {
            StringBuilder sqlstringBuilder = new StringBuilder();
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int i = 0;
            sqlstringBuilder.AppendFormat("UPDATE {0} set", typeof(T).Name);
            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                var vaule = props[i].GetValue(item, null);
                if (t == typeof(string))
                {
                    sqlstringBuilder.AppendFormat(" {0}='{1}',", prop.Name, vaule);
                }
                else if (t == typeof(DateTime))
                {
                    sqlstringBuilder.AppendFormat(" {0}= datetime(‘{1}’),", prop.Name, vaule);
                }
                else
                {
                    sqlstringBuilder.AppendFormat(" {0}={1},", prop.Name, vaule);
                }
                i++;
            }
            return sqlstringBuilder.Remove(sqlstringBuilder.Length - 1, 1).ToString();
        }

        /// <summary>
        /// SQLite 语句处理时内容类
        /// </summary>
        class sqliteInster
        {
            /// <summary>
            /// 字段类型
            /// </summary>
            public Type TypeName { get; set; }

            /// <summary>
            /// 字段值
            /// </summary>
            public object Value { get; set; }
        }

        #endregion


        /// <summary>
        /// 如果类型可空，则返回基础类型，否则返回类型
        /// </summary>
        private static Type GetCoreType(Type t)
        {
            if (t != null && IsNullable(t))
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }
        /// <summary>
        /// 指定类型是否可为空
        /// </summary>
        private static bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }



    }
}
