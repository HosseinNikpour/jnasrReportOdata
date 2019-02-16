using sharepointWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace SharepointWebApiV3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
          //  builder.EntitySet<Product>("Products");
            builder.EntitySet<WBS>("WBS");
            builder.EntitySet<WeeklyExec>("Weekly");
            builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends");
            builder.EntitySet<CommitTrendUnpivot>("CommitTrends");

            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends11");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends12");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends13");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends21");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends22");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends23");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends31");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends32");
            //builder.EntitySet<CommitTrendUnpivot>("CommitTrends33");

            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends11");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends12");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends13");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends21");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends22");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends23");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends31");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends32");
            //builder.EntitySet<WeeklyTrendUnpivot>("WeeklyTrends33");
            builder.EntitySet<Tahvil>("Deliver");
            builder.EntitySet<Tahvil2>("Deliver2");
            builder.EntitySet<TahvilTrend>("DeliverTrends");

            builder.EntitySet<Finance>("Finance");
            builder.EntitySet<Cost>("Cost");
            builder.EntitySet<CostV2>("CostV2");
            builder.EntitySet<CostDetails>("CostDetails");
            builder.EntitySet<Progress>("Progress");
            builder.EntitySet<Evaluation>("Evaluation");
            builder.EntitySet<CostFromList>("CostFromList");
            builder.EntitySet<CommitmentAndWeekly97>("CommitmentAndWeekly97");
            builder.EntitySet<Commitment97First>("Commitment97First");

            builder.EntitySet<InvoiceCM>("InvoiceCM");
            builder.EntitySet<InvoiceConsultant>("InvoiceConsultant");

            config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
            // Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
