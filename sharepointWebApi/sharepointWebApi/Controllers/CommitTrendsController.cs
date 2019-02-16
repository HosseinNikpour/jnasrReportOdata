using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Query;
using sharepointWebApi.Models;


namespace sharepointWebApi.Controllers
{
 
    public class CommitTrendsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/CommitTrends
        public IHttpActionResult GetCommitTrends(ODataQueryOptions<CommitTrend> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[6];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
            parameterValues[5] = 2;

            var result = ctx.ReaderSp("GetCommitTrendTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

        // GET: odata/CommitTrends(5)
        public IHttpActionResult GetCommitTrend([FromODataUri] int level, ODataQueryOptions<CommitTrend> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[6];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = level;
            parameterValues[4] = 2;
            parameterValues[5] = 2;

            var result = ctx.ReaderSp("GetCommitTrendTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

    
    }
}
