using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.BusinessService.Models
{
    public class PostResultModel
    {

        public int code { get; set; }

        public string message { get; set; }

        public object data { get; set; }
    }
}
