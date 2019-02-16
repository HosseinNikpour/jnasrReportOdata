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
using sharepointWebApi.Models;


namespace sharepointWebApi.Controllers
{

    public class WeeklyExecsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/WeeklyExecs
        public IHttpActionResult GetWeeklyExecs(ODataQueryOptions<WeeklyExec> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 1;
            parameterValues[4] = System.DBNull.Value; ;


            var result = ctx.ReaderSp("GetWeeklyTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

        // GET: odata/WeeklyExecs(5)
        public IHttpActionResult GetWeeklyExec([FromODataUri] int level, ODataQueryOptions<WeeklyExec> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[5];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = level;
            parameterValues[4] = System.DBNull.Value; ;
    

            var result = ctx.ReaderSp("GetWeeklyTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

    }
}
