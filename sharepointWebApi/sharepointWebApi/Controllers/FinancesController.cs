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

    public class FinancesController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Finances
        public IHttpActionResult GetFinances(ODataQueryOptions<Finance> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[3];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            var result = ctx.ReaderSp("GetFinanceTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

        // GET: odata/Finances(5)
        public IHttpActionResult GetFinance([FromODataUri] int level, ODataQueryOptions<Finance> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[3];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = level;
            var result = ctx.ReaderSp("GetFinanceTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

     
    }
}
