using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sharepointWebApi.Models
{
    public class CostV2
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Area { get; set; }
        public int ContractID { get; set; }
        public string Contract { get; set; }
        public string Status { get; set; }
        public double FirstCost { get; set; }
        public string contractnumber { get; set; }
        public string Contractor { get; set; }
        public double Price { get; set; }
        public double NetworkFirst { get; set; }
        public double DrainFirst { get; set; }
        public double EquippFirst { get; set; }
        public double NetworkFinal { get; set; }
        public double DrainFinal { get; set; }
        public double EquippFinal { get; set; }
        public double ValueChange { get; set; }
        public string PaymentperiodInvoice { get; set; }
        public decimal ApprovedInvoiceNetwork { get; set; }
        public decimal ApprovedInvoiceEquipp { get; set; }
        public decimal PaidInvoiceNetwork { get; set; }
        public decimal PaidInvoiceEquipp { get; set; }
        public decimal EstimatedInvoiceConfirmNetwork { get; set; }
        public decimal EstimatedInvoiceConfirmEquipp { get; set; }
        public decimal BillingAmountReportNetwork { get; set; }
        public decimal BillingAmountReportEquipp { get; set; }
        public string PaymentperiodAdjustment { get; set; }
        public decimal ApprovedAdjustNetwork { get; set; }
        public decimal ApprovedAdjustEquipp { get; set; }
        public decimal PaidAdjustNetwork { get; set; }
        public decimal PaidAdjustEquipp { get; set; }
        public decimal EstimatedAdjustConfirmNetwork { get; set; }
        public decimal EstimatedAdjustConfirmEquipp { get; set; }
        public decimal BillingAdjustReportNetwork { get; set; }
        public decimal BillingAdjustReportEquipp { get; set; }
        public string Zone { get; set; }
        public string AgreementProject { get; set; }
        public string ConfirmationPeriodInvoice { get; set; }
        public string ConfirmationPeriodAdjustment { get; set; }

        public decimal lastInvoiceNetwork { get; set; }
        public decimal lastInvoiceEquipp { get; set; }

        public decimal lastAdjustNetwork { get; set; }
        public decimal lastAdjustEquipp { get; set; }


    }
}