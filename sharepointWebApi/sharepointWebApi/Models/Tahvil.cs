using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class Tahvil
    {
        public int ID { get; set; }
        public string Area { get; set; }
        public int AreaID { get; set; }
        public string Contract { get; set; }
        public int ContractID { get; set; }
        public string Status { get; set; }
        public string MainOperation { get; set; }
        public int MainOperationID { get; set; }
        public double Ready { get; set; }
        public double Document { get; set; }
        public double TempDeliver { get; set; }
        public double TempDeliverDate { get; set; }
        public double TempWithoutDefect { get; set; }
        public double TempDeadline { get; set; }
        public double Remove { get; set; }
        public double FinalDeliver { get; set; }


    }
}