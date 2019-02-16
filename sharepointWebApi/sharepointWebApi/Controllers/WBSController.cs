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
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using sharepointWebApi.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<WBS>("WBS");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class WBSController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/WBS
        public IHttpActionResult GetWBS(ODataQueryOptions<WBS> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[4];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = 1;

            var result = ctx.ReaderSp("GetWBSTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

        // GET: odata/WBS(5)
        public IHttpActionResult GetWBS([FromODataUri] int level, ODataQueryOptions<WBS> queryOptions)
        {
            DataContext ctx = new Controllers.DataContext();
            object[] parameterValues = new object[4];
            parameterValues[0] = System.DBNull.Value;
            parameterValues[1] = System.DBNull.Value;
            parameterValues[2] = 1;
            parameterValues[3] = level;
           
            var result = ctx.ReaderSp("GetWBSTotalQuery", parameterValues).AsEnumerable().AsQueryable();
            return Ok(result);
        }

    }
   
}
