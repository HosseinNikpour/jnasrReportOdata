using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class InvoiceCM
    {
        public int ID { get; set; }
        public string Area { get; set; }
        public string CM { get; set; }
        public int AreaID { get; set; }


        public string Consultant { get; set; }
        public int Counter { get; set; }
        public int Num { get; set; }
        public double Total { get; set; }
        public double Average { get; set; }
        public int LastNum { get; set; }
    }
}