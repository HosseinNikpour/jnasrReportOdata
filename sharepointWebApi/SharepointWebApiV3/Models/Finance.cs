﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class Finance
    {
        public int ID { get; set; }
        public string Counter { get; set; }
      public double ProjectCost { get; set; }
      public double ValueChangePrice { get; set; }
      public double NetworkCM { get; set; }
      public double EquippedCM { get; set; }
      public double AdjNetworkCM { get; set; }
      public double AdjEquippedCM { get; set; }
      public string Area { get; set; }
      public int AreaID { get; set; }
      public string Contract { get; set; }
      public int ContractID { get; set; }
      public double ChangeNumbers { get; set; }
      public int InvoiceNumbers { get; set; }
      public string LastNumber { get; set; }
      public string LastDate { get; set; }
      public string AdjLastNumber { get; set; }
      public string LastInvoiceAdjust { get; set; }
      public string InvoiceID { get; set; }

    }
}