using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.ControlTemplates
{
    public class ControlTemplateServiceWrapper : ServiceWrapper
    {
        public ControlTemplateServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/ControlTemplates/ControlTemplateService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "batch/?providerName={providerName}")]
        public bool BatchDeleteControlTemplates(Guid[] ids, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?providerName={providerName}", Method.POST);

            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{id}/?providerName={providerName}")]
        public bool DeleteControlTemplate(Guid id, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{id}/?providerName={providerName}", Method.DELETE);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "commonProperties/?controlType={controlType}")]
        public CollectionContext<DataItemPropertyViewModel> GetCommonProperties(string controlType)
        {
            var request = new RestRequest(this.ServiceUrl + "commonProperties/?controlType={controlType}", Method.GET);

            request.AddUrlSegment("controlType", controlType);
            
            return ExecuteRequest<CollectionContext<DataItemPropertyViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/{id}/?providerName={providerName}&VersionId={VersionId}")]
        public ItemContext<ControlPresentation> GetControlTemplate(Guid id, string providerName, Guid VersionId)
        {
            var request = new RestRequest(this.ServiceUrl + "/{id}/?providerName={providerName}&VersionId={VersionId}", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("VersionId", VersionId.ToString());

            return ExecuteRequest<ItemContext<ControlPresentation>>(request);
        }

        //[WebGet(UriTemplate = "?providerName={providerName}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&templateFilter={templateFilter}")]
        public CollectionContext<ControlTemplateViewModel> GetControlTemplates(string providerName, string sortExpression, int skip, int take, string filter, string templateFilter)
        {
            var request = new RestRequest(this.ServiceUrl + "?providerName={providerName}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&templateFilter={templateFilter}", Method.GET);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("templateFilter", templateFilter);

            return ExecuteRequest<CollectionContext<ControlTemplateViewModel>>(request);
        }

        //[WebGet(UriTemplate = "otherProperties/?controlType={controlType}")]
        public CollectionContext<DataItemPropertyViewModel> GetOtherProperties(string controlType)
        {
            var request = new RestRequest(this.ServiceUrl + "otherProperties/?controlType={controlType}", Method.GET);

            request.AddUrlSegment("controlType", controlType);

            return ExecuteRequest<CollectionContext<DataItemPropertyViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/sitelinks/{templateId}/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<SiteItemLinkViewModel> GetSharedSites(Guid templateId, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/sitelinks/{templateId}/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("templateId", templateId.ToString());
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<SiteItemLinkViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/versions/{id}/?providerName={providerName}&VersionId={VersionId}")]
        public ItemContext<ControlTemplateVersionInfo> GetTemplateVersionInfo(Guid id, string providerName, Guid VersionId)
        {
            var request = new RestRequest(this.ServiceUrl + "/versions/{id}/?providerName={providerName}&VersionId={VersionId}", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("VersionId", VersionId.ToString());

            return ExecuteRequest<ItemContext<ControlTemplateVersionInfo>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "restore/{id}/?providerName={providerName}")]
        public ItemContext<ControlPresentation> RestoreControlTemplate(ItemContext<ControlPresentation> context, Guid id, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "restore/{id}/?providerName={providerName}", Method.PUT);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(context), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<ControlPresentation>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "{id}/?providerName={providerName}")]
        public ItemContext<ControlPresentation> SaveControlTemplate(ItemContext<ControlPresentation> context, Guid id, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "{id}/?providerName={providerName}", Method.PUT);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(context), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<ControlPresentation>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/savesitelinks/{templateId}/")]
        public bool SaveSharedSites(Guid templateId, Guid[] sharedSiteIDs)
        {
            var request = new RestRequest(this.ServiceUrl + "/savesitelinks/{templateId}/", Method.PUT);

            request.AddUrlSegment("templateId", templateId.ToString());

            request.AddParameter("application/json", SerializeObject(sharedSiteIDs), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }
    }
}
