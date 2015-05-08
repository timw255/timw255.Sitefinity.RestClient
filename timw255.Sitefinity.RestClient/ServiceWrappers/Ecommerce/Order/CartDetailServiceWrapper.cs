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
    public class CartDetailServiceWrapper : ServiceWrapper
    {
        public CartDetailServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/CartDetail.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batchdelete/?provider={provider}")]
        public bool BatchDeleteCartDetails(Guid[] cartDetailIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batchdelete/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(cartDetailIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{cartDetailId}/?provider={provider}")]
        public bool DeleteCartDetail(Guid cartDetailId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartDetailId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("cartDetailId", cartDetailId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{cartDetailId}/?provider={providerName}")]
        public ItemContext<CartDetail> GetCartDetail(Guid cartDetailId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartDetailId}/?provider={providerName}", Method.GET);

            request.AddUrlSegment("cartDetailId", cartDetailId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<ItemContext<CartDetail>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<CartDetail> GetCartDetails(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<CartDetail>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{cartDetailId}/?provider={providerName}")]
        public ItemContext<CartDetail> SaveCartDetail(ItemContext<CartDetail> cartDetailContext, Guid cartDetailId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{cartDetailId}/?provider={providerName}", Method.PUT);

            request.AddUrlSegment("cartDetailId", cartDetailId.ToString());
            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(cartDetailContext), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<CartDetail>>(request);
        }
    }
}
