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
    public class BackendFormServiceWrapper : ServiceWrapper
    {
        public BackendFormServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/DynamicModules/BackendFormService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/?parentTypeId={parentTypeId}")]
        public CollectionContext<SectionFieldWrapper> GetBackendForms(Guid parentTypeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/?parentTypeId={parentTypeId}", Method.GET);

            request.AddUrlSegment("parentTypeId", parentTypeId.ToString());

            return ExecuteRequestFor<CollectionContext<SectionFieldWrapper>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/?parentTypeId={parentTypeId}")]
        public void ModifyBackendForms(SectionFieldWrapper[] sectionsAndFields, Guid parentTypeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/?parentTypeId={parentTypeId}", Method.PUT);

            request.AddUrlSegment("parentTypeId", parentTypeId.ToString());

            request.AddParameter("application/json", SerializeObject(sectionsAndFields), ParameterType.RequestBody);

            ExecuteRequest(request);
        }
    }
}
