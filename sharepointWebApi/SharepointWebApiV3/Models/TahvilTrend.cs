using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class TahvilTrend
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Area { get; set; }
        public int ContractID { get; set; }
        public string Contract { get; set; }
        public string Year { get; set; }
        public string Flag { get; set; }
        public string Month { get; set; }
        public string MainOperation { get; set; }
        public int MainOperationID { get; set; }
        //public  double Deliverylevel { get; set; }
        //public  double DeliverylevelCum { get; set; }
        public double Values { get; set; }


    }
}