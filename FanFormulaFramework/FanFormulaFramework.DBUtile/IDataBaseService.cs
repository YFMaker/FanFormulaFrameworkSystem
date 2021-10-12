using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FanFormulaFramework.DBUtile
{

    /// <summary>
    /// 数据库操作
    /// </summary>

    public interface IDataBaseService
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        int InsterSQL(string sql);
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        bool InsterSQL<T>(T item);
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        bool InsterSQL<T>(List<T> insterobjectitem, out int insterNum);

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        int DeleteSQL(string sql);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        bool DeleteSQL<T>(string keyword, object Value);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        bool DeleteSQL<T>(string keyword, List<object> Value);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        bool DeleteSQL<T>(Dictionary<string, object> keywordvalue);

        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        int UpdateSQL(string sql);
        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        bool UpdateSQL<T>(string keyword, object Value, string editkeyword, object editValue);
        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        bool UpdateSQL<T>(T newItem, string keyword, object Value);
        /// <summary>
        /// 更改
        /// </summary>
        /// <returns></returns>
        bool UpdateSQL<T>(T newItem, Dictionary<string, object> keywordValue);

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        DataTable SelectSQL(string sql);
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        T SelectSQL<T>(string sql);
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        DataTable SelectSQL(string sql, string orderByQuery, int maxpageNum = 10, int pageNum = 0);

    }
}
