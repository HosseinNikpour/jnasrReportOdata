using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class CostFromList
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Area { get; set; }
        public int ContractID { get; set; }
        public string Contract { get; set; }

        public double ValueChange { get; set; }
        public double FirstCost { get; set; }
        public double NetCumulativeAmountpaid { get; set; }
        public double EquipCumulativeAmountpaid { get; set; }
        public string PaymentperiodInvoice { get; set; }
        public double NetworkCM { get; set; }
        public double EquippedCM { get; set; }
        public string CMDate { get; set; }
        public double NetEstimatedInvoiceAmountConfirm { get; set; }
        public double EquipEstimatedInvoiceAmountConfi { get; set; }
        public double NetEstimatedBillingAmountReporti { get; set; }
        public double EquipEstimatedBillingAmountRepor { get; set; }
        public double NetAmountCumulativeAdjustmentpai { get; set; }
        public double EquipAmountCumulativeAdjustmentp { get; set; }
        public string PaymentperiodAdjustment { get; set; }
        public double NetworkA { get; set; }
        public double EquippedA { get; set; }
        public string CMDateA { get; set; }
        public double NetstimatedAdjustmentAmountConfi { get; set; }
        public double EquipstimatedAdjustmentAmountCon { get; set; }
        public double NetAdjustmentBillingAmountReport { get; set; }
        public double EquipAdjustmentBillingAmountRepo { get; set; }

        public string ConfirmationPeriodInvoice { get; set; }
        public string ConfirmationPeriodAdjustment { get; set; }
    }
}