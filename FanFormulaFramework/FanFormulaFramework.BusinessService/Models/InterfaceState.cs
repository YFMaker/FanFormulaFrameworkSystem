using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Models
{
    /// <summary>
    /// 接口
    /// </summary>
    public class InterfaceState
    {

        /// <summary>
        /// 接口名称
        /// </summary>
        public string InterFaceName { get; set; }

        /// <summary>
        /// 接口状态
        /// </summary>
        public bool InterFaceStated { get; set; }

        /// <summary>
        /// 备注（执行反馈、描述反馈）
        /// </summary>
        public string Remarke { get; set; }
    }

}
