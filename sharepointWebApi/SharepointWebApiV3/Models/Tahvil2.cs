using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class Tahvil2
    {
        public int ID { get; set; }
        public string Area { get; set; }
        public int AreaID { get; set; }
        public string Contract { get; set; }
        public int ContractID { get; set; }
        public string Status { get; set; }
        public string MainOperation { get; set; }
        public int MainOperationID { get; set; }

        public double TempDeliver { get; set; }
        public double TempWithoutDefect { get; set; }
        public double TempDeadline { get; set; }
        public double Remove { get; set; }

        public double Guarantee { get; set; }
        public double Reason1 { get; set; }
        public double Reason2 { get; set; }
        public double Reason3 { get; set; }
        public double Reason4 { get; set; }
        public double Reason5 { get; set; }
        public double Reason6 { get; set; }

        public double Deadline1 { get; set; }
        public double Deadline2 { get; set; }
        public double Deadline3 { get; set; }
        public double Deadline4 { get; set; }
        public double Deadline5 { get; set; }
        public double Deadline6 { get; set; }
    }
}