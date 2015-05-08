using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Reports
{
    public class OrdersReportsServiceWrapper : ServiceWrapper
    {
        public OrdersReportsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Reports/OrdersReports.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "summaryreport/?provider={provider}&fromDate={fromDate}&toDate={toDate}")]
        public ItemContext<OrderSummaryReportViewModel> GetSummaryReport(string provider, DateTime fromDate, DateTime toDate)
        {
            var request = new RestRequest(this.ServiceUrl + "summaryreport/?provider={provider}&fromDate={fromDate}&toDate={toDate}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("fromDate", fromDate.ToString());
            request.AddUrlSegment("toDate", toDate.ToString());

            return ExecuteRequest<ItemContext<OrderSummaryReportViewModel>>(request);
        }
    }
}
