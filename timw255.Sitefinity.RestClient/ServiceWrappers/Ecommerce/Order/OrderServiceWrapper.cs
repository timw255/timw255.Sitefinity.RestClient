using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Order
{
    public class OrderServiceWrapper : ServiceWrapper
    {
        public OrderServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/Order.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}")]
        public bool BatchDeleteOrders(Guid[] orderIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(orderIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{orderId}/?provider={provider}")]
        public bool DeleteOrder(Guid orderId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{orderId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("orderId", orderId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{orderId}/?provider={provider}")]
        public ItemContext<timw255.Sitefinity.RestClient.Model.Order> GetOrder(Guid orderId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{orderId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("orderId", orderId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<timw255.Sitefinity.RestClient.Model.Order>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&status={status}")]
        public CollectionContext<timw255.Sitefinity.RestClient.Model.Order> GetOrders(string provider, string sortExpression, int skip, int take, string filter, int status)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&status={status}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("status", status.ToString());

            return ExecuteRequest<CollectionContext<timw255.Sitefinity.RestClient.Model.Order>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/markaspaid/?provider={provider}")]
        public bool MarkAsPaid(Guid orderId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/markaspaid/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(orderId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/markasshipped/?provider={provider}")]
        public bool MarkAsShipped(Guid orderId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/markasshipped/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(orderId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }
    }
}
