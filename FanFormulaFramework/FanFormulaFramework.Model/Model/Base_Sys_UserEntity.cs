using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFormulaFramework.Model
{
    public partial class Base_Sys_UserEntity : BaseEntity
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        public Base_Sys_UserEntity()
        {

        }

        /// <summary>
        /// 从数据行读取
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        protected override BaseEntity GetFrom(IDataRow dataRow)
        {
            throw new NotImplementedException();
        }
    }
}
