using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Order
{
    public class PaymentMethodServiceWrapper : ServiceWrapper
    {
        public PaymentMethodServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Order/PaymentMethod.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}&language={deletedLanguage}")]
        public bool BatchDeletePaymentMethods(Guid[] paymentMethodIds, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}&language={deletedLanguage}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            request.AddParameter("application/json", SerializeObject(paymentMethodIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{paymentMethodId}/?provider={provider}&language={deletedLanguage}")]
        public bool DeletePaymentMethod(Guid paymentMethodId, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/{paymentMethodId}/?provider={provider}&language={deletedLanguage}", Method.DELETE);

            request.AddUrlSegment("paymentMethodId", paymentMethodId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{paymentMethodId}/?provider={provider}")]
        public ItemContext<PaymentMethod> GetPaymentMethod(Guid paymentMethodId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{paymentMethodId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("paymentMethodId", paymentMethodId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<PaymentMethod>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<PaymentMethod> GetPaymentMethods(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<PaymentMethod>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeactive/?provider={provider}")]
        public bool MakeActive(Guid paymentMethodId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(paymentMethodId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeinactive/?provider={provider}")]
        public bool MakeInActive(Guid paymentMethodId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeinactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(paymentMethodId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{paymentMethodId}/?provider={provider}")]
        public ItemContext<PaymentMethod> SavePaymentMethod(Guid paymentMethodId, ItemContext<PaymentMethod> paymentMethod, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{paymentMethodId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("paymentMethodId", paymentMethodId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(paymentMethod), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<PaymentMethod>>(request);
        }
    }
}
