using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.OData;
using System.Web.OData.Query;
using System.Web.OData.Routing;
using sharepointWebApi.Models;

namespace sharepointWebApi.Controllers
{
  
    public class WeeklyTrendsController : ODataController
    {
     //   private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/WeeklyTrends
        public IHttpActionResult GetWeeklyTrends(ODataQueryOptions<WeeklyTrend> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[6];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 1;
            parameterValues[4] = 2;
            parameterValues[5] = 2;

            var result = ctx.ReaderSp("GetWeeklyTrendTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

        // GET: odata/WeeklyTrends(5)
        public IHttpActionResult GetWeeklyTrend([FromODataUri] int level, ODataQueryOptions<WeeklyTrend> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[6];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = level;
            parameterValues[4] = 2;
            parameterValues[5] = 2;

            var result = ctx.ReaderSp("GetWeeklyTrendTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

    }
}
