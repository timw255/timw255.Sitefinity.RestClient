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
    public class CartAddressServiceWrapper : ServiceWrapper
    {
        public CartAddressServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/CartAddress.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batchdelete/?provider={provider}")]
        public bool BatchDeleteCartAddresses(Guid[] cartAddressIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batchdelete/?provider={provider}", Method.POST);

            request.AddParameter("application/json", SerializeObject(cartAddressIds), ParameterType.RequestBody);

            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{cartAddressId}/?provider={provider}")]
        public bool DeleteCartAddress(Guid cartAddressId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartAddressId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("cartAddressId", cartAddressId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{cartAddressId}/?provider={providerName}")]
        public ItemContext<CartAddress> GetCartAddress(Guid cartAddressId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartAddressId}/?provider={providerName}", Method.GET);

            request.AddUrlSegment("cartAddressId", cartAddressId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<ItemContext<CartAddress>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<CartAddress> GetCartAddresses(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<CartAddress>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{cartAddressId}/?provider={providerName}")]
        public ItemContext<CartAddress> SaveCartAddress(ItemContext<CartAddress> cartAddressContext, Guid cartAddressId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartAddressId}/?provider={providerName}", Method.PUT);

            request.AddUrlSegment("cartAddressId", cartAddressId.ToString());
            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(cartAddressContext), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<CartAddress>>(request);
        }
    }
}
