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
    public class CartDiscountServiceWrapper : ServiceWrapper
    {
        public CartDiscountServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/CartDiscount.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}")]
        public bool BatchDeleteCartDiscounts(Guid[] cartDiscountIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(cartDiscountIds), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{cartDiscountId}/?provider={provider}")]
        public bool DeleteCartDiscount(Guid cartDiscountId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartDiscountId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("cartDiscountId", cartDiscountId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebGet(UriTemplate = "/{cartDiscountId}/?provider={provider}")]
        public ItemContext<CartDiscount> GetCartDiscount(Guid cartDiscountId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartDiscountId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("cartDiscountId", cartDiscountId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<ItemContext<CartDiscount>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<CartDiscount> GetCartDiscounts(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<CartDiscount>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{cartDiscountId}/?provider={provider}")]
        public ItemContext<CartDiscount> SaveCartDiscount(Guid cartDiscountId, ItemContext<CartDiscount> cartDiscount, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartDiscountId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("cartDiscountId", cartDiscountId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(cartDiscount), ParameterType.RequestBody);

            return ExecuteRequestFor<ItemContext<CartDiscount>>(request);
        }
    }
}
