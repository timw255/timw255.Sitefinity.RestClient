using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Localization
{
    public class AllCulturesResourceServiceWrapper : ServiceWrapper
    {
        public AllCulturesResourceServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Localization/AllCulturesResource.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate="{classId=null}/{key=null}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ResourceEntry> GetResources(Guid classId, string key, string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "{classId}/{key}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("classId", classId.ToString());
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<ResourceEntry>>(request);
        }

        //[WebInvoke(Method="PUT", UriTemplate="{uiCulture}/{classId}/{key}/?provider={provider}")]
        public ResourceEntry SaveResource(string[][] propertyBag, string uiCulture, Guid classId, string key, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{uiCulture}/{classId}/{key}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("uiCulture", uiCulture);
            request.AddUrlSegment("classId", classId.ToString());
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(propertyBag), ParameterType.RequestBody);

            return ExecuteRequest<ResourceEntry>(request);
        }
    }
}
