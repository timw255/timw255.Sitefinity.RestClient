using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.DynamicModules
{
    public class ContentTypeServiceWrapper : ServiceWrapper
    {
        public ContentTypeServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/DynamicModules/ContentTypeService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/activate/?provider={provider}")]
        public ContentTypeContext ActivateModule(Guid moduleId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/activate/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(moduleId), ParameterType.RequestBody);

            return ExecuteRequestFor<ContentTypeContext>(request);
        }

        //[WebGet(UriTemplate = "/checkModuleName/?moduleName={moduleName}")]
        public ModuleNameContext CheckIfModuleWithSpecifiedNameAlreadyExists(string moduleName)
        {
            var request = new RestRequest(this.ServiceUrl + "/checkModuleName/?moduleName={moduleName}", Method.GET);

            request.AddUrlSegment("moduleName", moduleName);

            return ExecuteRequestFor<ModuleNameContext>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/deactivate/?provider={provider}")]
        public ContentTypeContext DeactivateModule(Guid moduleId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/deactivate/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(moduleId), ParameterType.RequestBody);

            return ExecuteRequestFor<ContentTypeContext>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/content-type/{contentTypeId}/?moduleId={moduleId}&provider={provider}")]
        public DeleteContentTypeContext DeleteDynamicContentType(Guid contentTypeId, Guid moduleId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/content-type/{contentTypeId}/?moduleId={moduleId}&provider={provider}", Method.DELETE);

            request.AddUrlSegment("contentTypeId", contentTypeId.ToString());
            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<DeleteContentTypeContext>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{moduleId}/?provider={provider}&deleteData={deleteData}")]
        public DeleteContentTypeContext DeleteModule(Guid moduleId, string provider, bool deleteData)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/?provider={provider}&deleteData={deleteData}", Method.DELETE);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deleteData", deleteData.ToString());

            return ExecuteRequestFor<DeleteContentTypeContext>(request);
        }

        //[WebGet(UriTemplate = "/{moduleId}/types/{contentTypeId}/?provider={provider}")]
        public ContentTypeContext GetContentType(Guid moduleId, Guid contentTypeId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/types/{contentTypeId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("contentTypeId", contentTypeId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<ContentTypeContext>(request);
        }

        //[WebGet(UriTemplate = "/{moduleId}/types/{contentTypeId}/availableparents/?provider={provider}")]
        public CollectionContext<ContentTypeContext> GetContentTypeAvailableParents(Guid moduleId, Guid contentTypeId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/types/{contentTypeId}/availableparents/?provider={provider}", Method.GET);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("contentTypeId", contentTypeId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<CollectionContext<ContentTypeContext>>(request);
        }

        //[WebGet(UriTemplate = "/{moduleId}/types/{contentTypeId}/types/?provider={provider}", ResponseFormat = WebMessageFormat.Xml)]
        public CollectionContext<ContentTypeContext> GetContentTypeChildren(Guid moduleId, Guid contentTypeId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/types/{contentTypeId}/types/?provider={provider}", Method.GET);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("contentTypeId", contentTypeId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<CollectionContext<ContentTypeContext>>(request);
        }

        //[WebGet(UriTemplate = "/{moduleId}/types/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ContentTypeContext> GetContentTypes(Guid moduleId, string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/types/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<ContentTypeContext>>(request);
        }

        //[WebGet(UriTemplate = "/{moduleId}/types/tree/?provider={provider}&filter={filter}")]
        public CollectionContext<ContentTypeTreeItemContext> GetContentTypesTree(Guid moduleId, string provider, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/types/tree/?provider={provider}&filter={filter}", Method.GET);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<ContentTypeTreeItemContext>>(request);
        }

        //[WebGet(UriTemplate = "/{moduleId}/?provider={provider}")]
        public ContentTypeContext GetModule(Guid moduleId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<ContentTypeContext>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ContentTypeContext> GetModules(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<ContentTypeContext>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{moduleId}/?provider={provider}&updateWidgetTemplates={updateWidgetTemplates}")]
        public ContentTypeContext SaveContentType(Guid moduleId, ContentTypeContext contentType, string provider, bool updateWidgetTemplates)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/?provider={provider}&updateWidgetTemplates={updateWidgetTemplates}", Method.PUT);

            request.AddUrlSegment("moduleId", moduleId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("updateWidgetTemplates", updateWidgetTemplates.ToString());

            request.AddParameter("application/json", SerializeObject(contentType), ParameterType.RequestBody);

            return ExecuteRequestFor<ContentTypeContext>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{moduleId}/updateModuleName/")]
        public ContentTypeSimpleContext UpdateModuleNameAndDescription(Guid moduleId, ContentTypeSimpleContext contentTypeContext)
        {
            var request = new RestRequest(this.ServiceUrl + "/{moduleId}/updateModuleName/", Method.PUT);

            request.AddUrlSegment("moduleId", moduleId.ToString());

            request.AddParameter("application/json", SerializeObject(contentTypeContext), ParameterType.RequestBody);

            return ExecuteRequestFor<ContentTypeSimpleContext>(request);
        }
    }
}
