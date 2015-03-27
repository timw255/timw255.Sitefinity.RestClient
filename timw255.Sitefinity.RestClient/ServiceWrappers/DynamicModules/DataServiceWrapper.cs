using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.DynamicModules
{
    public class DataServiceWrapper : ServiceWrapper
    {
        public DataServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/DynamicModules/Data.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "parent/{parentId}/batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&itemType={itemType}&checkRelatingData={checkRelatingData}")]
        public bool BatchDeleteChildItems(Guid[] ids, Guid parentId, string providerName, string workflowOperation, string deletedLanguage, string itemType, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "parent/{parentId}/batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&itemType={itemType}&checkRelatingData={checkRelatingData}", Method.POST);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&itemType={itemType}&checkRelatingData={checkRelatingData}")]
        public bool BatchDeleteItems(Guid[] Ids, string providerName, string workflowOperation, string deletedLanguage, string itemType, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&itemType={itemType}&checkRelatingData={checkRelatingData}", Method.POST);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            request.AddParameter("application/json", SerializeObject(Ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/publish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}")]
        public bool BatchPublish(Guid[] ids, string providerName, string workflowOperation, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/publish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("itemType", itemType);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "parent/{parentId}/batch/publish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}")]
        public bool BatchPublishChildItems(Guid[] ids, Guid parentId, string providerName, string workflowOperation, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "parent/{parentId}/batch/publish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("itemType", itemType);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}")]
        public bool BatchUnpublish(Guid[] ids, string providerName, string workflowOperation, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("itemType", itemType);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/parent/{parentId}/batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}")]
        public bool BatchUnpublishChildItems(Guid[] ids, Guid parentId, string providerName, string workflowOperation, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}&itemType={itemType}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("itemType", itemType);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/parent/{parentId}/{dataItemId}/?provider={providerName}&itemType={itemType}&parentItemType={parentItemType}&parentType={parentType}&checkRelatingData={checkRelatingData}&language={deletedLanguage}&version={version}")]
        public bool DeleteChildDataItem(Guid parentId, Guid dataItemId, string providerName, string itemType, string parentItemType, string parentType, string deletedLanguage, bool checkRelatingData, string version)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{dataItemId}/?provider={providerName}&itemType={itemType}&parentItemType={parentItemType}&parentType={parentType}&checkRelatingData={checkRelatingData}&language={deletedLanguage}&version={version}", Method.DELETE);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("dataItemId", dataItemId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("parentItemType", parentItemType);
            request.AddUrlSegment("parentType", parentType);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("version", version);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{dataItemId}/?provider={provider}&itemType={itemType}&language={deletedLanguage}&checkRelatingData={checkRelatingData}&version={version}")]
        public bool DeleteDataItem(Guid dataItemId, string provider, string itemType, string deletedLanguage, bool checkRelatingData, string version)
        {
            var request = new RestRequest(this.ServiceUrl + "/{dataItemId}/?provider={provider}&itemType={itemType}&language={deletedLanguage}&checkRelatingData={checkRelatingData}&version={version}", Method.DELETE);

            request.AddUrlSegment("dataItemId", dataItemId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());
            request.AddUrlSegment("version", version);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/temp/{dataItemId}/?provider={provider}&force={force}")]
        public bool DeleteTempItem(Guid dataItemId, string provider, bool force)
        {
            var request = new RestRequest(this.ServiceUrl + "/temp/{dataItemId}/?provider={provider}&force={force}", Method.DELETE);

            request.AddUrlSegment("dataItemId", dataItemId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("force", force.ToString());

            return ExecuteRequestFor<bool>(request);
        }

        //[WebGet(UriTemplate = "/parent/{parentId}/{itemId}/?provider={providerName}&version={version}&itemType={itemType}&duplicate={duplicate}&checkOut={checkOut}")]
        public DynamicItemContext GetChildDataItem(Guid parentId, Guid itemId, string providerName, string version, string itemType, bool duplicate, bool checkOut = false)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{itemId}/?provider={providerName}&version={version}&itemType={itemType}&duplicate={duplicate}&checkOut={checkOut}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("duplicate", duplicate.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());

            return ExecuteRequestFor<DynamicItemContext>(request);
        }

        //[WebGet(UriTemplate = "/parent/{parentId}/?provider={provider}&itemType={itemType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<DynamicContent> GetChildDataItems(Guid parentId, string itemType, string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/?provider={provider}&itemType={itemType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<DynamicContent>>(request);
        }

        //[WebGet(UriTemplate = "children/{parentId}/?provider={provider}&filter={filter}&itemType={itemType}")]
        public CollectionContext<DynamicContent> GetChildItems(Guid parentId, string provider, string filter, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "children/{parentId}/?provider={provider}&filter={filter}&itemType={itemType}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("itemType", itemType);
            
            return ExecuteRequestFor<CollectionContext<DynamicContent>>(request);
        }

        //[WebGet(UriTemplate = "/{itemId}/?provider={providerName}&itemType={itemType}&version={version}&duplicate={duplicate}&checkOut={checkOut}")]
        public DynamicItemContext GetDataItem(Guid itemId, string providerName, string version, string itemType, bool duplicate, bool checkOut = false)
        {
            var request = new RestRequest(this.ServiceUrl + "/{itemId}/?provider={providerName}&itemType={itemType}&version={version}&duplicate={duplicate}&checkOut={checkOut}", Method.GET);

            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("duplicate", duplicate.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());

            return ExecuteRequestFor<DynamicItemContext>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&hierarchyMode={hierarchyMode}")]
        public CollectionContext<DynamicContent> GetDataItems(string provider, string sortExpression, int skip, int take, string filter, string itemType, bool hierarchyMode = false)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&hierarchyMode={hierarchyMode}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("hierarchyMode", hierarchyMode.ToString());

            return ExecuteRequestFor<CollectionContext<DynamicContent>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "tree/?provider={provider}&childLimit={childLimit}&perLevelLimit={perLevelLimit}&perSubtreeLimit={perSubtreeLimit}&subtreesLimit={subtreesLimit}&root={root}&itemType={itemType}&filter={filter}")]
        public CollectionContext<DynamicContent> GetItemsAsTree(Guid[] leafIds, string provider, int childLimit, int perLevelLimit, int perSubtreeLimit, int subtreesLimit, string root, string itemType, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "tree/?provider={provider}&childLimit={childLimit}&perLevelLimit={perLevelLimit}&perSubtreeLimit={perSubtreeLimit}&subtreesLimit={subtreesLimit}&root={root}&itemType={itemType}&filter={filter}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("childLimit", childLimit.ToString());
            request.AddUrlSegment("perLevelLimit", perLevelLimit.ToString());
            request.AddUrlSegment("perSubtreeLimit", perSubtreeLimit.ToString());
            request.AddUrlSegment("subtreesLimit", subtreesLimit.ToString());
            request.AddUrlSegment("root", root);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("filter", filter);

            request.AddParameter("application/json", SerializeObject(leafIds), ParameterType.RequestBody);

            return ExecuteRequestFor<CollectionContext<DynamicContent>>(request);
        }

        //[WebGet(UriTemplate = "/live/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&radius={radius}&latitude={latitude}&longitude={longitude}&geoLocationProperty={geoLocationProperty}")]
        public CollectionContext<DynamicContent> GetLiveDataItems(string provider, string sortExpression, int skip, int take, string filter, string itemType, double latitude = 0, double longitude = 0, double radius = 0, string geoLocationProperty = null)
        {
            var request = new RestRequest(this.ServiceUrl + "/live/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&itemType={itemType}&radius={radius}&latitude={latitude}&longitude={longitude}&geoLocationProperty={geoLocationProperty}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("radius", radius.ToString());
            request.AddUrlSegment("latitude", latitude.ToString());
            request.AddUrlSegment("longitude", longitude.ToString());
            request.AddUrlSegment("geoLocationProperty", geoLocationProperty);

            return ExecuteRequestFor<CollectionContext<DynamicContent>>(request);
        }

        //[WebGet(UriTemplate = "predecessor/{itemId}/?provider={providerName}&itemType={itemType}&filter={filter}")]
        public CollectionContext<DynamicContent> GetPredecessorItems(Guid itemId, string itemType, string providerName, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "predecessor/{itemId}/?provider={providerName}&itemType={itemType}&filter={filter}", Method.GET);

            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<DynamicContent>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/parent/{parentId}/{dataItemId}/?provider={provider}&itemType={itemType}&workflowOperation={workflowOperation}&parentType={parentType}&newParentId={newParentId}")]
        public DynamicItemContext SaveChildDataItem(DynamicItemContext dataItem, Guid parentId, Guid dataItemId, string provider, string itemType, string workflowOperation, string parentType, Guid newParentId)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{dataItemId}/?provider={provider}&itemType={itemType}&workflowOperation={workflowOperation}&parentType={parentType}&newParentId={newParentId}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("dataItemId", dataItemId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("parentType", parentType);
            request.AddUrlSegment("newParentId", newParentId.ToString());

            request.AddParameter("application/json", SerializeObject(dataItem), ParameterType.RequestBody);

            return ExecuteRequestFor<DynamicItemContext>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{dataItemId}/?provider={provider}&itemType={itemType}&workflowOperation={workflowOperation}")]
        public DynamicItemContext SaveDataItem(DynamicItemContext dataItem, Guid dataItemId, string provider, string itemType, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/{dataItemId}/?provider={provider}&itemType={itemType}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("dataItemId", dataItemId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(dataItem), ParameterType.RequestBody);

            return ExecuteRequestFor<DynamicItemContext>(request);
        }
    }
}
