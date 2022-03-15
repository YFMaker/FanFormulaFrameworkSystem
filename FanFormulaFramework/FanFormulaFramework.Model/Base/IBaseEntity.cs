using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Model
{
    public interface IBaseEntity
    {
        BaseEntity GetFrom(DataRow dr);

        BaseEntity GetFrom(IDataReader dataReader);

        BaseEntity GetSingle(DataTable dt);
    }
}
