using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class CostDetails
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Area { get; set; }
        public int ContractID { get; set; }
        public string Contract { get; set; }
        public string MainOperation { get; set; }
        public int MainOperationID { get; set; }
        public string Operation { get; set; }
        public int OperationID { get; set; }
        public string SubOperation { get; set; }
        public int SubOperationID { get; set; }
        public string Measurement { get; set; }

        public double FinalVolume { get; set; }
        public double FinalCost { get; set; }
        public double Norm1 { get; set; }
        public string LastNumber { get; set; }
        public string LastDate { get; set; }
        public double LastCost { get; set; }
        public double LastConstructed { get; set; }
        public double NowConstructed { get; set; }
        public double NowCost { get; set; }
        public double WorkLeft { get; set; }
        public double CostLeft { get; set; }
        public double TotalConstructed { get; set; }
        public double TotalCost { get; set; }
        
    }
}