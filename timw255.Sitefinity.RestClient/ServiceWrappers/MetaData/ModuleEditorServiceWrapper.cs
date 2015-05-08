using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.MetaData
{
    public class ModuleEditorServiceWrapper : ServiceWrapper
    {
        public ModuleEditorServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/MetaData/ModuleEditor.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "applyChanges/?providerName={providerName}")]
        public void ApplyChanges(ModuleEditorContext context, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "applyChanges/?providerName={providerName}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", context, ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebGet(UriTemplate = "custom/?contentType={contentType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={provider}")]
        public CollectionContext<FieldViewModel> GetCustomFields(string contentType, string sortExpression, int skip, int take, string filter, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "custom/?contentType={contentType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={provider}", Method.GET);

            request.AddUrlSegment("contentType", contentType);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<CollectionContext<FieldViewModel>>(request);
        }

        //[WebGet(UriTemplate = "default/?contentType={contentType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<FieldViewModel> GetDefaultFields(string contentType, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "default/?contentType={contentType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("contentType", contentType);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<FieldViewModel>>(request);
        }

        //[WebGet(UriTemplate = "views/?itemType={itemType}")]
        public CollectionContext<WcfDetailFormViewData> GetDetailFormViewNames(string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "views/?itemType={itemType}", Method.GET);

            request.AddUrlSegment("itemType", itemType);

            return ExecuteRequest<CollectionContext<WcfDetailFormViewData>>(request);
        }
    }
}
