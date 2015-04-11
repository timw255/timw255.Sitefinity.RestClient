using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Taxonomies
{
    public class FlatTaxonServiceWrapper : ServiceWrapper
    {
        public FlatTaxonServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Taxonomies/FlatTaxon.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "{taxonomyId}/batch/?provider={provider}&language={language}")]
        public bool BulkDeleteTaxons(Guid[] taxonIds, Guid taxonomyId, string provider, string language)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/batch/?provider={provider}&language={language}", Method.POST);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("language", language);

            request.AddParameter("application/json", SerializeObject(taxonIds), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{taxonomyId}/{taxonId}/?provider={provider}&itemType={itemType}&lang={lang}")]
        public bool DeleteTaxon(Guid taxonomyId, Guid taxonId, string provider, string itemType, string lang)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/{taxonId}/?provider={provider}&itemType={itemType}&lang={lang}", Method.DELETE);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("lang", lang);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{taxonomyId}/ensure/?provider={provider}&itemType={itemType}")]
        public IEnumerable<WcfFlatTaxon> EnsureTaxa(Guid taxonomyId, string[] taxonTitles, string provider, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxonomyId}/ensure/?provider={provider}&itemType={itemType}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);

            request.AddParameter("application/json", SerializeObject(taxonTitles), ParameterType.RequestBody);

            return ExecuteRequestFor<IEnumerable<WcfFlatTaxon>>(request);
        }

        //[WebGet(UriTemplate = "/{taxonomyId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&mode={mode}")]
        public CollectionContext<WcfFlatTaxon> GetTaxa(Guid taxonomyId, string provider, string sortExpression, int skip, int take, string filter, string itemType, string mode)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxonomyId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&mode={mode}", Method.GET);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("mode", mode);

            return ExecuteRequestFor<CollectionContext<WcfFlatTaxon>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "{taxonomyId}/")]
        public CollectionContext<WcfFlatTaxon> GetTaxaExtended(Guid taxonomyId, TaxaFilter filter)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/", Method.POST);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());

            request.AddParameter("application/json", SerializeObject(filter), ParameterType.RequestBody);

            return ExecuteRequestFor<CollectionContext<WcfFlatTaxon>>(request);
        }

        //[WebGet(UriTemplate = "/{taxonomyId}/{taxonId}/?provider={provider}&itemType={itemType}")]
        public WcfFlatTaxon GetTaxon(Guid taxonomyId, Guid taxonId, string provider, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxonomyId}/{taxonId}/?provider={provider}&itemType={itemType}", Method.GET);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);

            return ExecuteRequestFor<WcfFlatTaxon>(request);
        }

        //[WebInvoke(Method="PUT", UriTemplate="/{taxonomyId}/{taxonId}/?provider={provider}&itemType={itemType}&skipSiteContext={skipSiteContext}", ResponseFormat=WebMessageFormat.Json)]
        public WcfFlatTaxon SaveTaxon(WcfFlatTaxon wcfTaxon, Guid taxonomyId, Guid taxonId, string provider, string itemType, bool skipSiteContext)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxonomyId}/{taxonId}/?provider={provider}&itemType={itemType}&skipSiteContext={skipSiteContext}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("skipSiteContext", skipSiteContext.ToString());

            request.AddParameter("application/json", SerializeObject(wcfTaxon), ParameterType.RequestBody);

            return ExecuteRequestFor<WcfFlatTaxon>(request);
        }
    }
}
