using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Modules.Ecommerce.Catalog.Web.UI.Fields;
using Telerik.Sitefinity.Modules.Ecommerce.Configuration.ViewModels;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce
{
    public class CurrencyDataServiceWrapper : ServiceWrapper
    {
        public CurrencyDataServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/CurrencyData.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method="GET", UriTemplate="/ExchangeRates/CalcPrices/?currentPrice={currentPrice}", ResponseFormat=WebMessageFormat.Json)]
        public List<PriceKeyValue> CalculateCurrencyPrices(decimal currentPrice)
        {
            var request = new RestRequest(this.ServiceUrl + "/ExchangeRates/CalcPrices/?currentPrice={currentPrice}", Method.GET);

            request.AddUrlSegment("currentPrice", currentPrice.ToString());

            return ExecuteRequestFor<List<PriceKeyValue>>(request);
        }

        //[WebInvoke(Method="GET", UriTemplate="/AllowedCurrencies/?siteId={siteId}", ResponseFormat=WebMessageFormat.Json)]
        public CurrenciesAllowedSettingsViewModel GetAllowedCurrenices(Guid siteId)
        {
            var request = new RestRequest(this.ServiceUrl + "/AllowedCurrencies/?siteId={siteId}", Method.GET);

            request.AddUrlSegment("siteId", siteId.ToString());

            return ExecuteRequestFor<CurrenciesAllowedSettingsViewModel>(request);
        }

        //[WebInvoke(Method="GET", UriTemplate="/Currencies/?filter={filter}", ResponseFormat=WebMessageFormat.Json)]
        public CollectionContext<CurrencyViewModel> GetCurrencyInfo(string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/Currencies/?filter={filter}", Method.GET);

            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<CurrencyViewModel>>(request);
        }

        //[WebInvoke(Method="GET", UriTemplate="/ExchangeRates/?serviceId={serviceId}&requestedCurrencies={requestedCurrencies}&defaultCurrency={defaultCurrency}&siteId={siteId}", ResponseFormat=WebMessageFormat.Json)]
        public ExchangeRateResponseViewModel GetExchangeRates(Guid serviceId, string requestedCurrencies, string defaultCurrency, Guid siteId)
        {
            var request = new RestRequest(this.ServiceUrl + "/ExchangeRates/?serviceId={serviceId}&requestedCurrencies={requestedCurrencies}&defaultCurrency={defaultCurrency}&siteId={siteId}", Method.GET);

            request.AddUrlSegment("serviceId", serviceId.ToString());
            request.AddUrlSegment("requestedCurrencies", requestedCurrencies);
            request.AddUrlSegment("defaultCurrency", defaultCurrency);
            request.AddUrlSegment("siteId", siteId.ToString());

            return ExecuteRequestFor<ExchangeRateResponseViewModel>(request);
        }

        //[WebInvoke(Method="PUT", UriTemplate="allowedcurrencies/{key}/?siteId={siteId}", ResponseFormat=WebMessageFormat.Json)]
        public void SaveCurrenciesBasicSettings(ItemContext<CurrenciesAllowedSettingsViewModel> allowedCurrenciesSettings, string key, Guid siteId)
        {
            var request = new RestRequest(this.ServiceUrl + "allowedcurrencies/{key}/?siteId={siteId}", Method.PUT);

            request.AddUrlSegment("key", key);
            request.AddUrlSegment("siteId", siteId.ToString());

            request.AddParameter("application/json", SerializeObject(allowedCurrenciesSettings), ParameterType.RequestBody);

            ExecuteRequest(request);
        }
    }
}
