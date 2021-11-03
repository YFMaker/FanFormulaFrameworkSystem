using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FanFormulaFramework.DBUtile
{
    public class DataBaseService : IDataBaseService
    {
        public DataBaseService()
        {

        }



        public int DeleteSQL(string sql)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSQL<T>(string keyword, object Value)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSQL<T>(string keyword, List<object> Value)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSQL<T>(Dictionary<string, object> keywordvalue)
        {
            throw new NotImplementedException();
        }

        public int InsterSQL(string sql)
        {
            throw new NotImplementedException();
        }

        public bool InsterSQL<T>(T item)
        {
            throw new NotImplementedException();
        }

        public bool InsterSQL<T>(List<T> insterobjectitem, out int insterNum)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectSQL(string sql)
        {
            throw new NotImplementedException();
        }

        public T SelectSQL<T>(string sql)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectSQL(string sql, string orderByQuery, int maxpageNum = 10, int pageNum = 0)
        {
            throw new NotImplementedException();
        }

        public int UpdateSQL(string sql)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSQL<T>(string keyword, object Value, string editkeyword, object editValue)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSQL<T>(T newItem, string keyword, object Value)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSQL<T>(T newItem, Dictionary<string, object> keywordValue)
        {
            throw new NotImplementedException();
        }
    }
}
