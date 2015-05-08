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
    public class TaxonomyServiceWrapper : ServiceWrapper
    {
        public TaxonomyServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Taxonomies/Taxonomy.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method="POST", UriTemplate="batch/?providerName={providerName}&itemType={itemType}&language={deletedLanguage}&deleteTaxaOnly={deleteTaxaOnly}", ResponseFormat=WebMessageFormat.Json)]
        public bool BatchDeleteTaxonomy(Guid[] Ids, string itemType, string providerName, string deletedLanguage, bool deleteTaxaOnly)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?providerName={providerName}&itemType={itemType}&language={deletedLanguage}&deleteTaxaOnly={deleteTaxaOnly}", Method.POST);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("deleteTaxaOnly", deleteTaxaOnly.ToString());

            request.AddParameter("application/json", SerializeObject(Ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //7.3 - [WebInvoke(Method = "DELETE", UriTemplate = "{taxonomyId}/?provider={provider}&lang={lang}")]
        //8.0 - [WebInvoke(Method="DELETE", UriTemplate="{taxonomyId}/?provider={provider}&lang={lang}&deleteTaxaOnly={deleteTaxaOnly}")]
        public bool DeleteTaxonomy(Guid taxonomyId, string provider, string lang, bool deleteTaxaOnly)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/?provider={provider}&lang={lang}&deleteTaxaOnly={deleteTaxaOnly}", Method.DELETE);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("lang", lang);
            request.AddUrlSegment("deleteTaxaOnly", deleteTaxaOnly.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&taxonomyType={taxonomyType}")]
        public CollectionContext<WcfTaxonomy> GetTaxonomies(string provider, string sortExpression, int skip, int take, string filter, string taxonomyType)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&taxonomyType={taxonomyType}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("taxonomyType", taxonomyType);

            return ExecuteRequest<CollectionContext<WcfTaxonomy>>(request);
        }

        //[WebGet(UriTemplate = "{taxonomyId}/?provider={provider}")]
        public WcfTaxonomy GetTaxonomy(Guid taxonomyId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<WcfTaxonomy>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{taxonomyId}/?provider={provider}")]
        public WcfTaxonomy SaveTaxonomy(WcfTaxonomy taxonomy, Guid taxonomyId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxonomyId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(taxonomy), ParameterType.RequestBody);

            return ExecuteRequest<WcfTaxonomy>(request);
        }
    }
}
