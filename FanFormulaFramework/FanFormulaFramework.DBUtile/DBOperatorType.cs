using System;
using System.Collections.Generic;
using System.Text;

namespace FanFormulaFramework.DBUtile
{
    public enum DBOperatorType
    {
        /// <summary>
        /// 插入
        /// </summary>
        InsterSQL,
        /// <summary>
        /// 删除
        /// </summary>
        DeleteSQL,
        /// <summary>
        /// 更改
        /// </summary>
        UpdateSQL,
        /// <summary>
        /// 查询
        /// </summary>
        SelectSQL,
    }
}
