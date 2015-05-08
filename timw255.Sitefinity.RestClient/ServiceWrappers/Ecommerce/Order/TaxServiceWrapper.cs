using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Order
{
    public class TaxServiceWrapper : ServiceWrapper
    {
        public TaxServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/Tax.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}&language={deletedLanguage}")]
        public bool BatchDeleteTaxes(Guid[] taxIds, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}&language={deletedLanguage}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            request.AddParameter("application/json", SerializeObject(taxIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{taxId}/?provider={provider}&language={deletedLanguage}")]
        public bool DeleteTax(Guid taxId, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxId}/?provider={provider}&language={deletedLanguage}", Method.DELETE);

            request.AddUrlSegment("taxId", taxId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{taxId}/?provider={provider}")]
        public ItemContext<Tax> GetTax(Guid taxId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("taxId", taxId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<Tax>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<TaxViewModel> GetTaxes(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<TaxViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{taxId}/?provider={provider}")]
        public ItemContext<Tax> SaveTax(Guid taxId, ItemContext<Tax> tax, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxId", taxId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(tax), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<Tax>>(request);
        }
    }
}
