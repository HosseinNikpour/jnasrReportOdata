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

    public class TahvilsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Tahvils
        public IHttpActionResult GetTahvils(ODataQueryOptions<Tahvil> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[4];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = System.DBNull.Value;
            parameterValues[3] = 1;

            var result = ctx.ReaderSp("GetDeliverDataTotal", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

        // GET: odata/Tahvils(5)
        public IHttpActionResult GetTahvil([FromODataUri] int level, ODataQueryOptions<Tahvil> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[4];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = System.DBNull.Value;
            parameterValues[3] = level;

            var result = ctx.ReaderSp("GetDeliverDataTotal", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

    }
}
