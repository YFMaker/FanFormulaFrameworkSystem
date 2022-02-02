using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Models
{
    /// <summary>
    /// 接口列表
    /// </summary>
    public class InterFaceStateList
    {

        public InterFaceStateList()
        {
            interfaceStates = new List<InterfaceState>();
        }

        /// <summary>
        /// 接口列表
        /// </summary>
        public List<InterfaceState> interfaceStates { get; set; }
    }
}
