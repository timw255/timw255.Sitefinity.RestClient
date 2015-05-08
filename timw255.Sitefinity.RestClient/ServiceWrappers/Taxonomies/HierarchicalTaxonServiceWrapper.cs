using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Taxonomies
{
    public class HierarchicalTaxonServiceWrapper : ServiceWrapper
    {
        public HierarchicalTaxonServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Taxonomies/HierarchicalTaxon.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batchchangeparent/{taxonomyId}/?provider={provider}")]
        public void BatchChangeParent(Guid taxonomyId, WcfBatchChangeParent parentChangeObject, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "batchchangeparent/{taxonomyId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(parentChangeObject), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "{taxonomyId}/batch/?provider={provider}&language={language}")]
        public bool BatchDeleteTaxons(Guid[] taxonIds, Guid taxonomyId, string provider, string language)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/batch/?provider={provider}&language={language}", Method.POST);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("language", language);

            request.AddParameter("application/json", SerializeObject(taxonIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batchpath/?provider={provider}&itemType={itemType}")]
        public CollectionContext<WcfHierarchicalTaxon[]> BatchGetPath(Guid[] taxonIds, string provider, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "batchpath/?provider={provider}&itemType={itemType}", Method.PUT);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);

            request.AddParameter("application/json", SerializeObject(taxonIds), ParameterType.RequestBody);

            return ExecuteRequest<CollectionContext<WcfHierarchicalTaxon[]>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batchmovedown/{taxonomyId}/?provider={provider}")]
        public void BatchMoveTaxonsDown(Guid[] taxonIds, Guid taxonomyId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "batchmovedown/{taxonomyId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(taxonIds), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batchmoveup/{taxonomyId}/?provider={provider}")]
        public void BatchMoveTaxonsUp(Guid[] taxonIds, Guid taxonomyId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "batchmoveup/{taxonomyId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(taxonIds), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "changeparent/{taxonomyId}/{taxonId}/?provider={provider}")]
        public void ChangeParent(Guid taxonomyId, Guid taxonId, Guid newParentId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "changeparent/{taxonomyId}/{taxonId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(newParentId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{taxonomyId}/{taxonId}/?provider={provider}&ordinal={ordinal}&insertionPosition={insertionPosition}&itemType={itemType}&lang={lang}")]
        public bool DeleteTaxon(Guid taxonomyId, Guid taxonId, string provider, string ordinal, string insertionPosition, string itemType, string lang)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/{taxonId}/?provider={provider}&ordinal={ordinal}&insertionPosition={insertionPosition}&itemType={itemType}&lang={lang}", Method.DELETE);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("ordinal", ordinal);
            request.AddUrlSegment("insertionPosition", insertionPosition);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("lang", lang);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/predecessor/{taxonId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&onlyPath={onlyPath}&itemType={itemType}&mode={mode}")]
        public CollectionContext<WcfHierarchicalTaxon> GetPredecessorTaxa(Guid taxonId, string provider, string sortExpression, int skip, int take, string filter, bool onlyPath, string itemType, string mode)
        {
            var request = new RestRequest(this.ServiceUrl + "/predecessor/{taxonId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&onlyPath={onlyPath}&itemType={itemType}&mode={mode}", Method.GET);

            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("onlyPath", onlyPath.ToString());
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("mode", mode);

            return ExecuteRequest<CollectionContext<WcfHierarchicalTaxon>>(request);
        }

        //[WebGet(UriTemplate = "subtaxa/{taxonId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&mode={mode}")]
        public CollectionContext<WcfHierarchicalTaxon> GetSubTaxa(Guid taxonId, string provider, string sortExpression, int skip, int take, string filter, string itemType, string mode)
        {
            var request = new RestRequest(this.ServiceUrl + "subtaxa/{taxonId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&mode={mode}", Method.GET);

            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("mode", mode);

            return ExecuteRequest<CollectionContext<WcfHierarchicalTaxon>>(request);
        }

        //[WebGet(UriTemplate = "/{taxonomyId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&hierarchyMode={hierarchyMode}&mode={mode}")]
        public CollectionContext<WcfHierarchicalTaxon> GetTaxa(Guid taxonomyId, string provider, string sortExpression, int skip, int take, string filter, string itemType, bool hierarchyMode, string mode)
        {
            var request = new RestRequest(this.ServiceUrl + "/{taxonomyId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&hierarchyMode={hierarchyMode}&mode={mode}", Method.GET);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("hierarchyMode", hierarchyMode.ToString());
            request.AddUrlSegment("mode", mode);

            return ExecuteRequest<CollectionContext<WcfHierarchicalTaxon>>(request);
        }

        //[WebGet(UriTemplate = "{taxonomyId}/{taxonId}/?provider={provider}&ordinal={ordinal}&insertionPosition={insertionPosition}&itemType={itemType}")]
        public WcfHierarchicalTaxon GetTaxon(Guid taxonomyId, Guid taxonId, string provider, string ordinal, string insertionPosition, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/{taxonId}/?provider={provider}&ordinal={ordinal}&insertionPosition={insertionPosition}&itemType={itemType}", Method.GET);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("ordinal", ordinal);
            request.AddUrlSegment("insertionPosition", insertionPosition);
            request.AddUrlSegment("itemType", itemType);

            return ExecuteRequest<WcfHierarchicalTaxon>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "movedown/{taxonomyId}/{taxonId}/?provider={provider}")]
        public void MoveTaxonDown(Guid taxonomyId, Guid taxonId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "movedown/{taxonomyId}/{taxonId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "moveup/{taxonomyId}/{taxonId}/?provider={provider}")]
        public void MoveTaxonUp(Guid taxonomyId, Guid taxonId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "moveup/{taxonomyId}/{taxonId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);

            ExecuteRequest(request);
        }

        //8.0 - [WebInvoke(Method = "PUT", UriTemplate = "{taxonomyId}/{taxonId}/?provider={provider}&ordinal={ordinal}&insertionPosition={insertionPosition}&itemType={itemType}&skipSiteContext={skipSiteContext}")]
        public WcfHierarchicalTaxon SaveTaxon(WcfHierarchicalTaxon wcfTaxon, Guid taxonomyId, Guid taxonId, string provider, string ordinal, string insertionPosition, string itemType, bool skipSiteContext)
        {
            var request = new RestRequest(this.ServiceUrl + "{taxonomyId}/{taxonId}/?provider={provider}&ordinal={ordinal}&insertionPosition={insertionPosition}&itemType={itemType}&skipSiteContext={skipSiteContext}", Method.PUT);

            request.AddUrlSegment("taxonomyId", taxonomyId.ToString());
            request.AddUrlSegment("taxonId", taxonId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("ordinal", ordinal);
            request.AddUrlSegment("insertionPosition", insertionPosition);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("skipSiteContext", skipSiteContext.ToString());

            request.AddParameter("application/json", SerializeObject(wcfTaxon), ParameterType.RequestBody);

            return ExecuteRequest<WcfHierarchicalTaxon>(request);
        }
    }
}
