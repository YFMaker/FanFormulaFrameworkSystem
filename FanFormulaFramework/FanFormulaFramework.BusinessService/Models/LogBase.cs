using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Models
{
    public class LogBase
    {
        public string ID { get; set; }

        public string BehaviorType { get; set; }

        public string PerformContent { get; set; }

        public string ExecutionTime { get; set; }
    }
}
