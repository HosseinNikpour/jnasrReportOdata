using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class Progress
    {
        public int ID { get; set; }
        public string Area { get; set; }
      public int AreaID { get; set; }
      public string Contract { get; set; }
      public int ContractID { get; set; }
      public double Percent { get; set; }
      public double Cost { get; set; }

    }
}