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
