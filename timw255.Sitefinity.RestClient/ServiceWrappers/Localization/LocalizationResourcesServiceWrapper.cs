using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Localization
{
    public class LocalizationResourcesServiceWrapper : ServiceWrapper
    {
        public LocalizationResourcesServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Localization/LocalizationResources.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{cultureName}/{classId}/{key}/?provider={provider}")]
        public bool DeleteResource(string cultureName, Guid classId, string key, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{cultureName}/{classId}/{key}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("cultureName", cultureName);
            request.AddUrlSegment("classId", classId.ToString());
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "{cultureName}/{classId}/{key}/?provider={provider}")]
        public ResourceEntry GetResource(string cultureName, Guid classId, string key, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{cultureName}/{classId}/{key}/?provider={provider}", Method.GET);

            request.AddUrlSegment("cultureName", cultureName);
            request.AddUrlSegment("classId", classId.ToString());
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ResourceEntry>(request);
        }

        //[WebGet(UriTemplate = "{cultureName=null}/{classId=null}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ResourceEntry> GetResources(string cultureName, Guid classId, string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "{cultureName}/{classId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("cultureName", cultureName);
            request.AddUrlSegment("classId", classId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<ResourceEntry>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "{cultureName}/{classId}/{key}/?provider={provider}")]
        public ResourceEntry SaveResource(string[][] propertyBag, string cultureName, Guid classId, string key, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{cultureName}/{classId}/{key}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("cultureName", cultureName);
            request.AddUrlSegment("classId", classId.ToString());
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(propertyBag), ParameterType.RequestBody);

            return ExecuteRequest<ResourceEntry>(request);
        }
    }
}
