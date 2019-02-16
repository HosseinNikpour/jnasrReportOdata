using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class Evaluation
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Area { get; set; }
        public int ContractID { get; set; }
        public string Contract { get; set; }
        public string Type { get; set; }
        public double TotalScore { get; set; }
        public double Rank { get; set; }
        public int PeriodID { get; set; }
        public string Period { get; set; }
        public string type2 { get; set; }
        public string CompanyName { get; set; }
    }
}