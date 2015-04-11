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
    public class CartServiceWrapper : ServiceWrapper
    {
        public CartServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/Cart.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/clear")]
        public void ClearCart(string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/clear", Method.DELETE);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/?orderId={cartOrderId}&provider={providerName}")]
        public ItemContext<CartOrder> GetCart(Guid cartOrderId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/?orderId={cartOrderId}&provider={providerName}", Method.GET);

            request.AddUrlSegment("cartOrderId", cartOrderId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequestFor<ItemContext<CartOrder>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/?orderId={cartOrderId}&provider={providerName}")]
        public ItemContext<CartOrder> GetCart(string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/?orderId={cartOrderId}&provider={providerName}", Method.GET);

            request.AddUrlSegment("cartOrderId", String.Empty);
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequestFor<ItemContext<CartOrder>>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/?cartDetailId={cartDetailId}&provider={providerName}")]
        public void RemoveFromCart(Guid cartDetailId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/?cartDetailId={cartDetailId}&provider={providerName}", Method.DELETE);

            request.AddUrlSegment("cartDetailId", cartDetailId.ToString());
            request.AddUrlSegment("providerName", providerName);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/?cartDetailId={cartDetailId}&qty={quantity}&provider={providerName}")]
        public void UpdateQuantity(Guid cartDetailId, int quantity, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/?cartDetailId={cartDetailId}&qty={quantity}&provider={providerName}", Method.POST);

            request.AddUrlSegment("cartDetailId", cartDetailId.ToString());
            request.AddUrlSegment("quantity", quantity.ToString());
            request.AddUrlSegment("providerName", providerName);

            ExecuteRequest(request);
        }
    }
}
