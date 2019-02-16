using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class InvoiceConsultant
    {
        public int ID { get; set; }
        public string Area { get; set; }
        public string Contract { get; set; }
        public int AreaID { get; set; }
        public int ContractID { get; set; }

        public string Consultant { get; set; }
        public int Counter { get; set; }
        public int Num { get; set; }
        public double Total { get; set; }
        public double Average { get; set; }
        public int LastNum { get; set; }
    }
}