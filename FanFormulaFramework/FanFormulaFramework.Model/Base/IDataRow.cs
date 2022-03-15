using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Model
{
    public interface IDataRow
    {
        object this[string name] { get; }
        object this[int i] { get; }
        bool ContainsColumn(string columnName);
    }
}
