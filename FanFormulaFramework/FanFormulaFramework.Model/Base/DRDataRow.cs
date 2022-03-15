using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Model
{
    class DRDataRow : IDataRow
    {
        private DataRow dr;

        public DRDataRow(DataRow dataRow)
        {
            this.dr = dataRow;
        }

        #region IDataRow 成员

        public object this[string name]
        {
            get
            {
                return dr[name];
            }
        }

        public object this[int i]
        {
            get
            {
                return dr[i];
            }
        }

        public bool ContainsColumn(string columnName)
        {
            return dr.Table.Columns.Contains(columnName);
        }

        #endregion
    }
}
