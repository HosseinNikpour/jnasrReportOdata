using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class WeeklyExec
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Area { get; set; }
        public int ContractID { get; set; }
        public string Contract { get; set; }
        public string ContractType { get; set; }
        public string MainOperation { get; set; }
        public int MainOperationID { get; set; }
        public string Operation { get; set; }
        public int OperationID { get; set; }
        public string SubOperation { get; set; }
        public int SubOperationID { get; set; }
        public string Measurement { get; set; }
        public double Cumulative { get; set; }
        public double Weekly { get; set; }
   

    }
}