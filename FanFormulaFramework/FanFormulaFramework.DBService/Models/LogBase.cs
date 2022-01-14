using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanFormulaFramework.DBService.Models
{
    public class LogBase
    {

        public string ID { get; set; }

        public string SQLLINQS 
        { 
            get; 
            set; 
        }

        public string INSETERtIME { get; set; }
    }
}
