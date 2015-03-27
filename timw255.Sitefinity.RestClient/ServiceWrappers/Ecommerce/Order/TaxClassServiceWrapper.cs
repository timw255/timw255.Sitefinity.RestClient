using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Ecommerce.Orders.Model;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Order
{
    public class TaxClassServiceWrapper : ServiceWrapper
    {
        public TaxClassServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/TaxClass.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}&language={deletedLanguage}")]
        public bool BatchDeleteTaxClasses(Guid[] taxClassIds, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}&language={deletedLanguage}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            request.AddParameter("application/json", SerializeObject(taxClassIds), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{taxClassId}/?provider={provider}&language={deletedLanguage}")]
        public bool DeleteTaxClass(Guid taxClassId, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxClassId}/?provider={provider}&language={deletedLanguage}", Method.DELETE);

            request.AddUrlSegment("taxClassId", taxClassId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebGet(UriTemplate = "/{taxClassId}/?provider={provider}")]
        public ItemContext<TaxClass> GetTaxClass(Guid taxClassId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxClassId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("taxClassId", taxClassId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<ItemContext<TaxClass>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeactive/?provider={provider}")]
        public bool MakeActive(Guid taxClassId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(taxClassId), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeinactive/?provider={provider}")]
        public bool MakeInActive(Guid taxClassId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeinactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(taxClassId), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{taxClassId}/?provider={provider}")]
        public ItemContext<TaxClass> SaveTaxClass(Guid taxClassId, ItemContext<TaxClass> taxClass, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxClassId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxClassId", taxClassId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(taxClass), ParameterType.RequestBody);

            return ExecuteRequestFor<ItemContext<TaxClass>>(request);
        }
    }
}
