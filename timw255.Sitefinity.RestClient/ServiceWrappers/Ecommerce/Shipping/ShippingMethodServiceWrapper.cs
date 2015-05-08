using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Shipping
{
    public class ShippingMethodServiceWrapper : ServiceWrapper
    {
        public ShippingMethodServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Shipping/ShippingMethod.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}&language={deletedLanguage}")]
        public bool BatchDeleteShippingMethods(Guid[] shippingMethodIds, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}&language={deletedLanguage}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            request.AddParameter("application/json", SerializeObject(shippingMethodIds), ParameterType.RequestBody);
            
            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{shippingMethodId}/?provider={provider}&language={deletedLanguage}")]
        public bool DeleteShippingMethod(Guid shippingMethodId, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/{shippingMethodId}/?provider={provider}&language={deletedLanguage}", Method.DELETE);

            request.AddUrlSegment("shippingMethodId", shippingMethodId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{shippingMethodId}/?provider={provider}")]
        public ItemContext<ShippingMethod> GetShippingMethod(Guid shippingMethodId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{shippingMethodId}/?provider={provider}", Method.GET);
            
            request.AddUrlSegment("shippingMethodId", shippingMethodId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<ShippingMethod>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ShippingMethod> GetShippingMethods(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<ShippingMethod>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeactive/?provider={provider}")]
        public bool MakeActive(Guid shippingMethodId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(shippingMethodId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeinactive/?provider={provider}")]
        public bool MakeInActive(Guid shippingMethodId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeinactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(shippingMethodId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{shippingMethodId}/?provider={provider}")]
        public ItemContext<ShippingMethod> SaveShippingMethod(Guid shippingMethodId, ItemContext<ShippingMethod> shippingMethod, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{shippingMethodId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("shippingMethodId", shippingMethodId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(shippingMethod), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<ShippingMethod>>(request);
        }
    }
}
