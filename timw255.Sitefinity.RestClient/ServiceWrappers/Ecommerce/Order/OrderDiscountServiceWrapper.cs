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
    public class OrderDiscountServiceWrapper : ServiceWrapper
    {
        public OrderDiscountServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/OrderDiscount.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}")]
        public bool BatchDeleteOrderDiscounts(Guid[] orderDiscountIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(orderDiscountIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{orderDiscountId}/?provider={provider}")]
        public bool DeleteOrderDiscount(Guid orderDiscountId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{orderDiscountId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("orderDiscountId", orderDiscountId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{orderDiscountId}/?provider={provider}")]
        public ItemContext<OrderDiscount> GetOrderDiscount(Guid orderDiscountId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{orderDiscountId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("orderDiscountId", orderDiscountId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<OrderDiscount>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<OrderDiscount> GetOrderDiscounts(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<OrderDiscount>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{orderDiscountId}/?provider={provider}")]
        public ItemContext<OrderDiscount> SaveOrderDiscount(Guid orderDiscountId, ItemContext<OrderDiscount> orderDiscount, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{orderDiscountId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("orderDiscountId", orderDiscountId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(orderDiscount), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<OrderDiscount>>(request);
        }
    }
}
