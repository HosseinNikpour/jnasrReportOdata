using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class Cost
    {
        public int ID { get; set; }
        public  int AreaID { get; set; }
      public  string Area { get; set; }
      public  int ContractID { get; set; }
      public  string Contract { get; set; }
      public  string ContractType { get; set; }
      public  double LastNumber { get; set; }
      public  string LastDate { get; set; }
      public  string EndDate { get; set; }
      public  double NetworkCM { get; set; }
      public  double EquippedCM { get; set; }
      public  double NetworkLast { get; set; }
      public  double EquippLast { get; set; }
      public  double NetworkNow { get; set; }
      public  double EquippNow { get; set; }
      public  double NetworkEstimate { get; set; }
      public  double EquippEstimate { get; set; }

    }
}