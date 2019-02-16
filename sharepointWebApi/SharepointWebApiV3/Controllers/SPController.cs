using sharepointWebApi.Models;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;

namespace sharepointWebApi.Controllers
{

    public class WBSController : ODataController
    {
        public IHttpActionResult GetWBS()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[4];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 3;//level
            var result = ctx.ReaderSp("GetWBSTotalQuery", parameterValues).ToList<WBS>();
            return Ok(result);
        }
        public IHttpActionResult GetWBS(int level)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[4];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = level;//level
            var result = ctx.ReaderSp("GetWBSTotalQuery", parameterValues).ToList<WBS>();
            return Ok(result);
        }
    }
    public class WeeklyController : ODataController
    {
        public IHttpActionResult GetWeekly()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 3;//level
            parameterValues[4] = System.DBNull.Value;
            var result = ctx.ReaderSp("GetWeeklyTotalQuery", parameterValues).ToList<WeeklyExec>();
            return Ok(result);
        }

    }

    #region Commit
    public class CommitTrendsController : ODataController
    {
        public IHttpActionResult GetCommitTrends()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends11Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends11()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
           // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends12Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends12()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 2;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends13Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends13()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends21Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends21()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 2;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends22Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends22()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 2;
            parameterValues[3] = 2;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends23Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends23()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 2;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends31Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends31()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends32Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends32()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 2;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    public class CommitTrends33Controller : ODataController
    {
        public IHttpActionResult GetCommitTrends33()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetCommitTrendUnpivotTotalQuery", parameterValues).ToList<CommitTrendUnpivot>();
            return Ok(result);
        }

    }
    #endregion

    #region Weekly
    public class WeeklyTrendsController : ODataController
    {
        public IHttpActionResult GetWeeklyTrends()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            //  var result = ctx.ReaderSp("WeeklyTrendUnpivot", parameterValues).ToList<WeeklyTrendUnpivot>();
            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends11Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends11()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends12Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends12()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 2;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends13Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends13()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends21Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends21()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 2;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends22Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends22()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 2;
            parameterValues[3] = 2;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends23Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends23()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 2;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends31Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends31()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends32Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends32()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 2;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }
    public class WeeklyTrends33Controller : ODataController
    {
        public IHttpActionResult GetWeeklyTrends33()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
            parameterValues[3] = 3;
            parameterValues[4] = 2;
            // parameterValues[5] = 1;

            var result = ctx.ReaderSp("GetWeeklyTrendUnpivotTotalQuery", parameterValues).ToList<WeeklyTrendUnpivot>();
            return Ok(result);
        }

    }

    #endregion

    public class DeliverTrendsController : ODataController
    {
        public IHttpActionResult GetDeliverTrends()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[3];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;
     
            var result=ctx.ReaderSp("GetDeliverByYear", parameterValues).ToList<TahvilTrend>();
            //var result = ctx.ReaderSp("GetDeliverTrendTotalQuery", parameterValues).ToList<TahvilTrend>();
            return Ok(result);
        }

    }
    public class DeliverController : ODataController
    {
        public IHttpActionResult GetDeliver()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = System.DBNull.Value;
            parameterValues[3] = 3;
            parameterValues[4] = System.DBNull.Value;

            var result = ctx.ReaderSp("GetDeliverDataTotalQuery", parameterValues).ToList<Tahvil>();
            return Ok(result);
        }

    }
    public class Deliver2Controller : ODataController
    {
        public IHttpActionResult GetDeliver2()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = System.DBNull.Value;
            parameterValues[3] = 3;
            parameterValues[4] = System.DBNull.Value;

            var result = ctx.ReaderSp("GetDeliverDataExcell", parameterValues).ToList<Tahvil2>();
            return Ok(result);
        }

    }
    public class CostController : ODataController
    {
        public IHttpActionResult GetCost()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
         


            var result = ctx.ReaderSp("GetCostReport", parameterValues).ToList<Cost>();
            return Ok(result);
        }

    }
    public class CostDetailsController : ODataController
    {
        public IHttpActionResult GetCostDetails()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;

            var result = ctx.ReaderSp("GetCostReportDetails", parameterValues).ToList<CostDetails>();
            return Ok(result);
        }

    }

    public class FinanceController : ODataController
    {
        public IHttpActionResult GetFinance()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[3];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;

            var result = ctx.ReaderSp("GetFinanceTotalQuery", parameterValues).ToList<Finance>();
            return Ok(result);
        }

    }
    public class ProgressController : ODataController
    {
        public IHttpActionResult GetProgress()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[3];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 3;

            var result = ctx.ReaderSp("GetProgressTotalQuery", parameterValues).ToList<Progress>();
            return Ok(result);
        }

    }

    public class EvaluationController : ODataController
    {
        public IHttpActionResult GetEvaluation()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
           

            var result = ctx.ReaderSp("GetEvaluationDashboard", parameterValues).ToList<Evaluation>();
            return Ok(result);
        }

    }

    public class CostFromListController : ODataController
    {
        public IHttpActionResult GetCostFromList()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;


            var result = ctx.ReaderSp("GetCreditFromList", parameterValues).ToList<CostFromList>();
            return Ok(result);
        }

    }

    public class CommitmentAndWeekly97Controller : ODataController
    {
        public IHttpActionResult GetCommitmentAndWeekly97()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;


            var result = ctx.ReaderSp("GetCommitmentAndWeekly", parameterValues).ToList<CommitmentAndWeekly97>();
            return Ok(result);
        }

    }

    public class InvoiceConsultantController : ODataController
    {
        public IHttpActionResult GetInvoiceConsultant()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;


            var result = ctx.ReaderSp("GetInvoiceConsultant", parameterValues).ToList<InvoiceConsultant>();
            return Ok(result);
        }

    }

    public class InvoiceCMController : ODataController
    {
        public IHttpActionResult GetInvoiceCM()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[1];
            parameterValues[0] = System.DBNull.Value;
            


            var result = ctx.ReaderSp("GetInvoiceCM", parameterValues).ToList<InvoiceCM>();
            return Ok(result);
        }

    }
    public class CostV2Controller : ODataController
    {
        public IHttpActionResult GetCostV2()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;


            var result = ctx.ReaderSp("GetCostReport2", parameterValues).ToList<CostV2>();
            return Ok(result);
        }

    }
    public class Commitment97FirstController : ODataController
    {
        public IHttpActionResult GetCommitment97First()
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[2];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;


            var result = ctx.ReaderSp("GetCommitmentFirst", parameterValues).ToList<Commitment97First>();
            return Ok(result);
        }

    }
}