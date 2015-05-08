using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public abstract class ContentServiceWrapper<TContent, TContentViewModel> : ServiceWrapper
        where TContent : ContentBase//Telerik.Sitefinity.GenericContent.Model.Content
        where TContentViewModel : ContentViewModelBase
    {
        //[WebInvoke(Method = "PUT", UriTemplate = "batch/{newParentId}/?provider={providerName}&workflowOperation={workflowOperation}")]
        public bool BatchChangeParent(Guid[] ids, Guid newParentId, string providerName, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/{newParentId}/?provider={providerName}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("newParentId", newParentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/parent/{parentId}/batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&checkRelatingData={checkRelatingData}")]
        public bool BatchDeleteChildContent(Guid[] Ids, Guid parentId, string providerName, string workflowOperation, string deletedLanguage, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&checkRelatingData={checkRelatingData}", Method.POST);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            request.AddParameter("application/json", SerializeObject(Ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&checkRelatingData={checkRelatingData}")]
        public bool BatchDeleteContent(Guid[] Ids, string providerName, string workflowOperation, string deletedLanguage, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?provider={providerName}&workflowOperation={workflowOperation}&language={deletedLanguage}&checkRelatingData={checkRelatingData}", Method.POST);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            request.AddParameter("application/json", SerializeObject(Ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "parent/{parentId}/batch/move/?providerName={providerName}&direction={direction}")]
        public void BatchMoveContent(Guid[] sourceContentIds, Guid parentId, string providerName, string direction)
        {
            var request = new RestRequest(this.ServiceUrl + "parent/{parentId}/batch/move/?providerName={providerName}&direction={direction}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("direction", direction);

            request.AddParameter("application/json", SerializeObject(sourceContentIds), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/parent/{parentId}/batch/place/?providerName={providerName}&placePosition={placePosition}&destination={destination}")]
        public CollectionContext<TContentViewModel> BatchPlaceContent(Guid[] sourcePageIds, Guid parentId, string providerName, string placePosition, string destination)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/batch/place/?providerName={providerName}&placePosition={placePosition}&destination={destination}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("placePosition", placePosition);
            request.AddUrlSegment("destination", destination);

            request.AddParameter("application/json", SerializeObject(sourcePageIds), ParameterType.RequestBody);

            return ExecuteRequest<CollectionContext<TContentViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/publish/?provider={providerName}&workflowOperation={workflowOperation}")]
        public bool BatchPublish(Guid[] ids, string providerName, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/publish/?provider={providerName}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "parent/{parentId}/batch/publish/?provider={providerName}&workflowOperation={workflowOperation}")]
        public bool BatchPublishChildItem(Guid[] ids, string providerName, Guid parentId, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "parent/{parentId}/batch/publish/?provider={providerName}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/batchReorder/?provider={providerName}&workflowOperation={workflowOperation}")]
        public void BatchReorderContent(Dictionary<string, float> contentIdnewOrdinal, string providerName, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/batchReorder/?provider={providerName}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(contentIdnewOrdinal), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}")]
        public bool BatchUnpublish(Guid[] ids, string providerName, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "parent/{parentId}/batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}")]
        public bool BatchUnpublishChildItem(Guid[] ids, string providerName, Guid parentId, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "parent/{parentId}/batch/unpublish/?provider={providerName}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "{contentId}/canRate/?provider={providerName}")]
        public bool CanRate(Guid contentId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "{contentId}/canRate/?provider={providerName}", Method.GET);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/parent/{parentId}/{id}/?provider={providerName}&newParentId={newParentId}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&checkRelatingData={checkRelatingData}")]
        public bool DeleteChildContent(Guid id, Guid parentId, string providerName, Guid newParentId, string version, bool published, bool checkOut, string workflowOperation, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{id}/?provider={providerName}&newParentId={newParentId}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&checkRelatingData={checkRelatingData}", Method.DELETE);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("newParentId", newParentId.ToString());
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("published", published.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{contentId}/?provider={providerName}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&language={deletedLanguage}&checkRelatingData={checkRelatingData}")]
        public bool DeleteContent(Guid contentId, string providerName, string version, bool published, bool checkOut, string workflowOperation, string deletedLanguage, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "/{contentId}/?provider={providerName}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&language={deletedLanguage}&checkRelatingData={checkRelatingData}", Method.DELETE);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("published", published.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/temp/{contentId}/?provider={providerName}&force={force}&workflowOperation={workflowOperation}")]
        public bool DeleteTemp(Guid contentId, string providerName, bool force, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/temp/{contentId}/?provider={providerName}&force={force}&workflowOperation={workflowOperation}", Method.DELETE);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("force", force.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/parent/{parentId}/{contentId}/?provider={providerName}&newParentId={newParentId}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&duplicate={duplicate}")]
        public ContentItemContext<TContent> GetChildContent(Guid parentId, Guid contentId, string providerName, Guid newParentId, string version, bool published, bool checkOut, string workflowOperation, bool duplicate)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{contentId}/?provider={providerName}&newParentId={newParentId}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&duplicate={duplicate}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("newParentId", newParentId.ToString());
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("published", published.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("duplicate", duplicate.ToString());

            return ExecuteRequest<ContentItemContext<TContent>>(request);
        }

        //[WebGet(UriTemplate = "/folder/parent/{parentId}/{contentId}/?provider={providerName}")]
        public ItemContext<FolderDetailViewModel> GetChildFolder(Guid parentId, Guid contentId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/folder/parent/{parentId}/{contentId}/?provider={providerName}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<ItemContext<FolderDetailViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/parent/{parentId}/?provider={providerName}&sortExpression={sortExpression}&filter={filter}&skip={skip}&take={take}&workflowOperation={workflowOperation}&excludeFolders={excludeFolders}&includeSubFoldersItems={includeSubFoldersItems}")]
        public CollectionContext<TContentViewModel> GetChildrenContentItems(Guid parentId, string providerName, string sortExpression, string filter, int skip, int take, string workflowOperation, bool excludeFolders, bool includeSubFoldersItems)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/?provider={providerName}&sortExpression={sortExpression}&filter={filter}&skip={skip}&take={take}&workflowOperation={workflowOperation}&excludeFolders={excludeFolders}&includeSubFoldersItems={includeSubFoldersItems}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("excludeFolders", excludeFolders.ToString());
            request.AddUrlSegment("includeSubFoldersItems", includeSubFoldersItems.ToString());

            return ExecuteRequest<CollectionContext<TContentViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/{contentId}/?provider={providerName}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&duplicate={duplicate}")]
        public ContentItemContext<TContent> GetContent(Guid contentId, string providerName, string version, bool published, bool checkOut, string workflowOperation, bool duplicate)
        {
            var request = new RestRequest(this.ServiceUrl + "/{contentId}/?provider={providerName}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}&duplicate={duplicate}", Method.GET);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("published", published.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);
            request.AddUrlSegment("duplicate", duplicate.ToString());

            return ExecuteRequest<ContentItemContext<TContent>>(request);
        }

        //[WebGet(UriTemplate = "/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&workflowOperation={workflowOperation}")]
        public CollectionContext<TContentViewModel> GetContentItems(string sortExpression, int skip, int take, string filter, string providerName, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&workflowOperation={workflowOperation}", Method.GET);

            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            return ExecuteRequest<CollectionContext<TContentViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/folders/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&hierarchyMode={hierarchyMode}")]
        public CollectionContext<FolderViewModel> GetFolders(string sortExpression, int skip, int take, string filter, string providerName, bool hierarchyMode)
        {
            var request = new RestRequest(this.ServiceUrl + "/folders/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&hierarchyMode={hierarchyMode}", Method.GET);

            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("hierarchyMode", hierarchyMode.ToString());

            return ExecuteRequest<CollectionContext<FolderViewModel>>(request);
        }

        //7.3 - [WebInvoke(Method = "POST", UriTemplate = "/folders/tree/?provider={provider}")]
        //8.0 - [WebInvoke(Method="POST", UriTemplate="/folders/tree/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&hierarchyMode={hierarchyMode}", ResponseFormat=WebMessageFormat.Json)]
        public CollectionContext<FolderViewModel> GetFoldersAsTree(string provider, string sortExpression, int skip, int take, string filter, bool hierarchyMode)
        {
            var request = new RestRequest(this.ServiceUrl + "/folders/tree/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&hierarchyMode={hierarchyMode}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("hierarchyMode", hierarchyMode.ToString());

            return ExecuteRequest<CollectionContext<FolderViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/live/{contentId}/?provider={providerName}")]
        public ContentItemContext<TContent> GetLiveContent(Guid contentId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/live/{contentId}/?provider={providerName}", Method.GET);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<ContentItemContext<TContent>>(request);
        }

        //[WebGet(UriTemplate = "/folders/predecessors/{folderId}/?provider={providerName}&sortExpression={sortExpression}&excludeNeighbours={excludeNeighbours}")]
        public CollectionContext<FolderViewModel> GetPredecessorFolders(Guid folderId, string providerName, string sortExpression, bool excludeNeighbours)
        {
            var request = new RestRequest(this.ServiceUrl + "/folders/predecessors/{folderId}/?provider={providerName}&sortExpression={sortExpression}&excludeNeighbours={excludeNeighbours}", Method.GET);

            request.AddUrlSegment("folderId", folderId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("excludeNeighbours", excludeNeighbours.ToString());

            return ExecuteRequest<CollectionContext<FolderViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/predecessor/{contentId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&onlyPath={onlyPath}&itemType={itemType}")]
        public CollectionContext<TContentViewModel> GetPredecessorItems(Guid contentId, string provider, string sortExpression, int skip, int take, string filter, bool onlyPath, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "/predecessor/{contentId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&onlyPath={onlyPath}&itemType={itemType}", Method.GET);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("onlyPath", onlyPath.ToString());
            request.AddUrlSegment("itemType", itemType);

            return ExecuteRequest<CollectionContext<TContentViewModel>>(request);
        }

        //[WebGet(UriTemplate = "{contentId}/rating/?provider={providerName}")]
        public decimal GetRating(Guid contentId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "{contentId}/rating/?provider={providerName}", Method.GET);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<decimal>(request);
        }

        //[WebGet(UriTemplate = "/folders/{folderId}/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&hierarchyMode={hierarchyMode}")]
        public CollectionContext<FolderViewModel> GetSubFolders(Guid folderId, string sortExpression, int skip, int take, string filter, string providerName, bool hierarchyMode)
        {
            var request = new RestRequest(this.ServiceUrl + "/folders/{folderId}/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&hierarchyMode={hierarchyMode}", Method.GET);

            request.AddUrlSegment("folderId", folderId.ToString());
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("hierarchyMode", hierarchyMode.ToString());

            return ExecuteRequest<CollectionContext<FolderViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/reorder/{contentId}/?provider={providerName}&oldPosition={oldPosition}&newPosition={newPosition}&workflowOperation={workflowOperation}")]
        public void ReorderContent(Guid contentId, string providerName, float oldPosition, float newPosition, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/reorder/{contentId}/?provider={providerName}&oldPosition={oldPosition}&newPosition={newPosition}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("oldPosition", oldPosition.ToString());
            request.AddUrlSegment("newPosition", newPosition.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{contentId}/rating/?provider={providerName}", RequestFormat = WebMessageFormat.Json)]
        public RatingResult ResetRating(Guid contentId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "{contentId}/rating/?provider={providerName}", Method.DELETE);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<RatingResult>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/parent/{parentId}/{contentId}/?provider={providerName}&newParentId={newParentId}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}")]
        public ContentItemContext<TContent> SaveChildContent(ContentItemContext<TContent> content, Guid parentId, Guid contentId, string providerName, Guid newParentId, string version, bool published, bool checkOut, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{contentId}/?provider={providerName}&newParentId={newParentId}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("newParentId", newParentId.ToString());
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("published", published.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(content), ParameterType.RequestBody);

            return ExecuteRequest<ContentItemContext<TContent>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/folder/parent/{parentId}/{contentId}/?provider={providerName}")]
        public ItemContext<FolderDetailViewModel> SaveChildFolder(ItemContext<FolderDetailViewModel> content, Guid parentId, Guid contentId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/folder/parent/{parentId}/{contentId}/?provider={providerName}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(content), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<FolderDetailViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{contentId}/?provider={providerName}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}")]
        public ContentItemContext<TContent> SaveContent(ContentItemContext<TContent> content, Guid contentId, string providerName, string version, bool published, bool checkOut, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/{contentId}/?provider={providerName}&version={version}&published={published}&checkOut={checkOut}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("version", version);
            request.AddUrlSegment("published", published.ToString());
            request.AddUrlSegment("checkOut", checkOut.ToString());
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(content), ParameterType.RequestBody);

            return ExecuteRequest<ContentItemContext<TContent>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "{contentId}/rating/?provider={providerName}", RequestFormat = WebMessageFormat.Json)]
        public RatingResult SetRating(decimal value, Guid contentId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "{contentId}/rating/?provider={providerName}", Method.PUT);

            request.AddUrlSegment("contentId", contentId.ToString());
            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(value), ParameterType.RequestBody);

            return ExecuteRequest<RatingResult>(request);
        }
    }
}
