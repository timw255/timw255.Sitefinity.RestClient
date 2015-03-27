using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Reports
{
    public class ProductsReportsServiceWrapper : ServiceWrapper
    {
        public ProductsReportsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Reports/ProductsReports.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "inventoryreport/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&specificProductType={specificProductType}")]
        public CollectionContext<InventoryReportViewModel> GetInventoryReport(string provider, string sortExpression, int skip, int take, string filter, string specificProductType)
        {
            var request = new RestRequest(this.ServiceUrl + "inventoryreport/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&specificProductType={specificProductType}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("specificProductType", specificProductType);

            return ExecuteRequestFor<CollectionContext<InventoryReportViewModel>>(request);
        }

        //[WebGet(UriTemplate = "topsellingreport/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&fromDate={fromDate}&toDate={toDate}")]
        public CollectionContext<TopSellingReportViewModel> GetTopSellingReport(string provider, string sortExpression, int skip, int take, string filter, DateTime fromDate, DateTime toDate)
        {
            var request = new RestRequest(this.ServiceUrl + "topsellingreport/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&fromDate={fromDate}&toDate={toDate}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("fromDate", fromDate.ToString());
            request.AddUrlSegment("toDate", toDate.ToString());

            return ExecuteRequestFor<CollectionContext<TopSellingReportViewModel>>(request);
        }
    }
}
