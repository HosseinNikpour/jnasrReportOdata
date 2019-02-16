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

    public class ProgressesController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Progresses
        public IHttpActionResult GetProgresses(ODataQueryOptions<Progress> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[3];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] =1;
 var result = ctx.ReaderSp("GetProgressTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

        // GET: odata/Progresses(5)
        public IHttpActionResult GetProgress([FromODataUri] int level, ODataQueryOptions<Progress> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[3];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = level;
            var result = ctx.ReaderSp("GetProgressTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

      
    }
}
