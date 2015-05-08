using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Pages
{
    public class PagesServiceWrapper : ServiceWrapper
    {
        public PagesServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Pages/PagesService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "BatchChangeOwner/{userId}/")]
        public void BatchChangePageOwner(Guid[] pageId, Guid userId)
        {
            var request = new RestRequest(this.ServiceUrl + "BatchChangeOwner/{userId}/", Method.PUT);

            request.AddUrlSegment("userId", userId.ToString());

            request.AddParameter("application/json", SerializeObject(pageId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batchChangeTemplate/?newTemplateId={newTemplateId}")]
        public IEnumerable<string> BatchChangeTemplate(Guid[] pageIDs, Guid newTemplateId)
        {
            var request = new RestRequest(this.ServiceUrl + "batchChangeTemplate/?newTemplateId={newTemplateId}", Method.PUT);

            request.AddUrlSegment("newTemplateId", newTemplateId.ToString());

            request.AddParameter("application/json", SerializeObject(pageIDs), ParameterType.RequestBody);

            return ExecuteRequest<string[]>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "batch/?providerName={providerName}&language={deletedLanguage}&checkRelatingData={checkRelatingData}")]
        public bool BatchDeleteContent(Guid[] Ids, string providerName, string deletedLanguage, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?providerName={providerName}&language={deletedLanguage}&checkRelatingData={checkRelatingData}", Method.POST);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            request.AddParameter("application/json", SerializeObject(Ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/move/?providerName={providerName}&direction={direction}&root={root}")]
        public void BatchMovePage(Guid[] sourcePageIds, string providerName, string direction, string root)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/move/?providerName={providerName}&direction={direction}&root={root}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("direction", direction);
            request.AddUrlSegment("root", root);

            request.AddParameter("application/json", SerializeObject(sourcePageIds), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/place/?providerName={providerName}&placePosition={placePosition}&destination={destination}&root={root}")]
        public CollectionContext<PageViewModel> BatchPlacePage(Guid[] sourcePageIds, string providerName, string placePosition, string destination, string root)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/place/?providerName={providerName}&placePosition={placePosition}&destination={destination}&root={root}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("placePosition", placePosition);
            request.AddUrlSegment("destination", destination);
            request.AddUrlSegment("root", root);

            request.AddParameter("application/json", SerializeObject(sourcePageIds), ParameterType.RequestBody);

            return ExecuteRequest<CollectionContext<PageViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batchPublishDraft/")]
        public void BatchPublishDraft(Guid[] pageIDs)
        {
            var request = new RestRequest(this.ServiceUrl + "batchPublishDraft/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageIDs), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/?providerName={providerName}&root={root}")]
        public CollectionContext<PageViewModel> BatchSavePage(WcfPage[] pageContexts, string providerName, string root)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?providerName={providerName}&root={root}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("root", root);

            request.AddParameter("application/json", SerializeObject(pageContexts), ParameterType.RequestBody);

            return ExecuteRequest<CollectionContext<PageViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batchUnpublishPage/")]
        public void BatchUnpublishPage(Guid[] pageIds)
        {
            var request = new RestRequest(this.ServiceUrl + "batchUnpublishPage/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageIds), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "ChangeOwner/{userId}/")]
        public void ChangePageOwner(Guid pageId, Guid userId)
        {
            var request = new RestRequest(this.ServiceUrl + "ChangeOwner/{userId}/", Method.PUT);

            request.AddUrlSegment("userId", userId.ToString());

            request.AddParameter("application/json", SerializeObject(pageId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "ChangeParent/{newParentPageId}/")]
        public void ChangePageParent(Guid pageId, Guid newParentPageId)
        {
            var request = new RestRequest(this.ServiceUrl + "ChangeParent/{newParentPageId}/", Method.PUT);

            request.AddUrlSegment("newParentPageId", newParentPageId.ToString());

            request.AddParameter("application/json", SerializeObject(pageId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "changeTemplate/{pageId}/?newTemplateId={newTemplateId}")]
        public bool ChangeTemplate(Guid pageId, Guid newTemplateId)
        {
            var request = new RestRequest(this.ServiceUrl + "changeTemplate/{pageId}/?newTemplateId={newTemplateId}", Method.PUT);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("newTemplateId", newTemplateId.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "CheckPageForChanges/{pageId}/?pageStatus={pageStatus}&pageVersion={pageVersion}&provider={provider}")]
        public CurrentPageState CheckPageForChanges(Guid pageId, string pageStatus, int pageVersion, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "CheckPageForChanges/{pageId}/?pageStatus={pageStatus}&pageVersion={pageVersion}&provider={provider}", Method.GET);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("pageStatus", pageStatus);
            request.AddUrlSegment("pageVersion", pageVersion.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<CurrentPageState>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "Pages/versions/copyversiontopage/?itemId={pageId}&versionId={versionId}")]
        public void CopyDraftPageAsNewDraft(Guid pageId, Guid versionId)
        {
            var request = new RestRequest(this.ServiceUrl + "Pages/versions/copyversiontopage/?itemId={pageId}&versionId={versionId}", Method.PUT);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("versionId", versionId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "Templates/versions/copyversiontopage/?itemId={itemId}&versionId={versionId}")]
        public void CopyDraftTemplateAsNewDraft(Guid itemId, Guid versionId)
        {
            var request = new RestRequest(this.ServiceUrl + "Templates/versions/copyversiontopage/?itemId={itemId}&versionId={versionId}", Method.PUT);

            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("versionId", versionId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{pageId}/?providerName={providerName}&duplicate={duplicate}&language={deletedLanguage}&checkRelatingData={checkRelatingData}")]
        public bool DeletePage(Guid pageId, string providerName, bool duplicate, string deletedLanguage, bool checkRelatingData)
        {
            var request = new RestRequest(this.ServiceUrl + "{pageId}/?providerName={providerName}&duplicate={duplicate}&language={deletedLanguage}&checkRelatingData={checkRelatingData}", Method.DELETE);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("duplicate", duplicate.ToString());
            request.AddUrlSegment("deletedLanguage", deletedLanguage);
            request.AddUrlSegment("checkRelatingData", checkRelatingData.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "Duplicate/")]
        public PageViewModel DuplicatePage(Guid pageDraftId)
        {
            var request = new RestRequest(this.ServiceUrl + "Duplicate/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageDraftId), ParameterType.RequestBody);

            return ExecuteRequest<PageViewModel>(request);
        }

        //[WebGet(UriTemplate = "children/{parentId}/?provider={provider}&filter={filter}")]
        public CollectionContext<PageViewModel> GetChildPages(Guid parentId, string provider, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "children/{parentId}/?provider={provider}&filter={filter}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<PageViewModel>>(request);
        }

        //[WebGet(UriTemplate = "hierarchy/{parentId}/?provider={provider}&filter={filter}&siteId={siteId}")]
        public CollectionContext<WcfPageNode> GetChildren(Guid parentId, string provider, string filter, Guid siteId)
        {
            var request = new RestRequest(this.ServiceUrl + "hierarchy/{parentId}/?provider={provider}&filter={filter}&siteId={siteId}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("siteId", siteId.ToString());

            return ExecuteRequest<CollectionContext<WcfPageNode>>(request);
        }

        //[WebGet(UriTemplate = "Template/GetDefaultBackend/")]
        public WcfPageTemplate GetDefaultBackendTemplateId()
        {
            var request = new RestRequest(this.ServiceUrl + "Template/GetDefaultBackend/", Method.GET);

            return ExecuteRequest<WcfPageTemplate>(request);
        }

        //[WebGet(UriTemplate = "Template/GetDefault/")]
        public WcfPageTemplate GetDefaultFrontendTemplateId()
        {
            var request = new RestRequest(this.ServiceUrl + "Template/GetDefault/", Method.GET);

            return ExecuteRequest<WcfPageTemplate>(request);
        }

        //[WebGet(UriTemplate = "{pageId}/?providerName={providerName}&duplicate={duplicate}")]
        public WcfPageContext GetPage(Guid pageId, string providerName, bool duplicate)
        {
            var request = new RestRequest(this.ServiceUrl + "{pageId}/?providerName={providerName}&duplicate={duplicate}", Method.GET);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("duplicate", duplicate.ToString());

            return ExecuteRequest<WcfPageContext>(request);
        }

        //[WebGet(UriTemplate = "?pageFilter={pageFilter}&hierarchyMode={hierarchyMode}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&root={root}")]
        public CollectionContext<PageViewModel> GetPages(string pageFilter, bool hierarchyMode, string sortExpression, int skip, int take, string filter, string root)
        {
            var request = new RestRequest(this.ServiceUrl + "?pageFilter={pageFilter}&hierarchyMode={hierarchyMode}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&root={root}", Method.GET);

            request.AddUrlSegment("pageFilter", pageFilter);
            request.AddUrlSegment("hierarchyMode", hierarchyMode.ToString());
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("root", root);

            return ExecuteRequest<CollectionContext<PageViewModel>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "tree/?provider={provider}&nodesLimit={nodesLimit}&perLevelLimit={perLevelLimit}&perSubtreeLimit={perSubtreeLimit}&subtreesLimit={subtreesLimit}&root={root}")]
        public CollectionContext<PageViewModel> GetPagesAsTree(Guid[] leafIds, string provider, int nodesLimit, int perLevelLimit, int perSubtreeLimit, int subtreesLimit, string root)
        {
            var request = new RestRequest(this.ServiceUrl + "tree/?provider={provider}&nodesLimit={nodesLimit}&perLevelLimit={perLevelLimit}&perSubtreeLimit={perSubtreeLimit}&subtreesLimit={subtreesLimit}&root={root}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("nodesLimit", nodesLimit.ToString());
            request.AddUrlSegment("perLevelLimit", perLevelLimit.ToString());
            request.AddUrlSegment("perSubtreeLimit", perSubtreeLimit.ToString());
            request.AddUrlSegment("subtreesLimit", subtreesLimit.ToString());
            request.AddUrlSegment("root", root);

            request.AddParameter("application/json", SerializeObject(leafIds), ParameterType.RequestBody);

            return ExecuteRequest<CollectionContext<PageViewModel>>(request);
        }

        //[WebGet(UriTemplate = "template/{pageId}/")]
        public WcfPageTemplate GetPageTemplate(Guid pageId)
        {
            var request = new RestRequest(this.ServiceUrl + "template/{pageId}/", Method.GET);

            request.AddUrlSegment("pageId", pageId.ToString());

            return ExecuteRequest<WcfPageTemplate>(request);
        }

        //[WebGet(UriTemplate = "Pages/versions/?itemId={itemId}&versionId={versionId}")]
        public PageTemplateDraftVersionInfo GetPageVersionInfo(Guid itemId, Guid versionId)
        {
            var request = new RestRequest(this.ServiceUrl + "Pages/versions/?itemId={itemId}&versionId={versionId}", Method.GET);

            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("versionId", versionId.ToString());

            return ExecuteRequest<PageTemplateDraftVersionInfo>(request);
        }

        //[WebGet(UriTemplate = "predecessor/{pageId}/?provider={provider}&filter={filter}")]
        public CollectionContext<PageViewModel> GetPredecessorPages(Guid pageId, string provider, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "predecessor/{pageId}/?provider={provider}&filter={filter}", Method.GET);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<PageViewModel>>(request);
        }

        //[WebGet(UriTemplate = "Templates/versions/?itemId={itemId}&versionId={versionId}")]
        public PageTemplateDraftVersionInfo GetTemplateVersionInfo(Guid itemId, Guid versionId)
        {
            var request = new RestRequest(this.ServiceUrl + "Templates/versions/?itemId={itemId}&versionId={versionId}", Method.GET);

            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("versionId", versionId.ToString());

            return ExecuteRequest<PageTemplateDraftVersionInfo>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "template/createFromMaster/?rootTaxonType={rootTaxonType}")]
        public WcfPageTemplate MakeTemplateFromMasterFile(string masterFilePath, string rootTaxonType)
        {
            var request = new RestRequest(this.ServiceUrl + "template/createFromMaster/?rootTaxonType={rootTaxonType}", Method.PUT);

            request.AddUrlSegment("rootTaxonType", rootTaxonType);

            request.AddParameter("application/json", SerializeObject(masterFilePath), ParameterType.RequestBody);

            return ExecuteRequest<WcfPageTemplate>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "MoveDown/")]
        public void MovePageDown(Guid pageDraftId)
        {
            var request = new RestRequest(this.ServiceUrl + "MoveDown/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageDraftId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "MoveUp/")]
        public void MovePageUp(Guid pageDraftId)
        {
            var request = new RestRequest(this.ServiceUrl + "MoveUp/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageDraftId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "PlaceAfter/?targetPageId={targetPageId}")]
        public void PlaceAfter(Guid pageId, Guid targetPageId)
        {
            var request = new RestRequest(this.ServiceUrl + "PlaceAfter/?targetPageId={targetPageId}", Method.PUT);

            request.AddUrlSegment("targetPageId", targetPageId.ToString());

            request.AddParameter("application/json", SerializeObject(pageId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "PlaceBefore/?targetPageId={targetPageId}")]
        public void PlaceBefore(Guid pageId, Guid targetPageId)
        {
            var request = new RestRequest(this.ServiceUrl + "PlaceBefore/?targetPageId={targetPageId}", Method.PUT);

            request.AddUrlSegment("targetPageId", targetPageId.ToString());

            request.AddParameter("application/json", SerializeObject(pageId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "PublishDraft/")]
        public void PublishDraft(Guid pageDraftId)
        {
            var request = new RestRequest(this.ServiceUrl + "PublishDraft/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageDraftId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "Template/RestoreDefault/")]
        public void RestoreTemplateToDefault(Guid templateId)
        {
            var request = new RestRequest(this.ServiceUrl + "Template/RestoreDefault/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(templateId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "{pageId}/?providerName={providerName}&duplicate={duplicate}")]
        public WcfPageContext SavePage(WcfPageContext pageContext, Guid pageId, string providerName, bool duplicate)
        {
            var request = new RestRequest(this.ServiceUrl + "{pageId}/?providerName={providerName}&duplicate={duplicate}", Method.PUT);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("duplicate", duplicate.ToString());

            request.AddParameter("application/json", SerializeObject(pageContext), ParameterType.RequestBody);

            return ExecuteRequest<WcfPageContext>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "Template/SetDefault/")]
        public void SetDefaultTemplate(Guid templateId)
        {
            var request = new RestRequest(this.ServiceUrl + "Template/SetDefault/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(templateId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "HomePage/Set/")]
        public void SetHomePage(Guid pageId)
        {
            var request = new RestRequest(this.ServiceUrl + "HomePage/Set/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "UnpublishPage/")]
        public void UnpublishPage(Guid pageId)
        {
            var request = new RestRequest(this.ServiceUrl + "UnpublishPage/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }
    }
}
