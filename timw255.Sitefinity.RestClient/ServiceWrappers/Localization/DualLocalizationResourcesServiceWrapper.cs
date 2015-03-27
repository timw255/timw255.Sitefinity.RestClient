using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Localization.Web;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Localization
{
    public class DualLocalizationResourcesServiceWrapper : ServiceWrapper
    {
        public DualLocalizationResourcesServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Localization/DualLocalizationResources.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{displayUICulture}/{editUICulture}/{displayClassId}/{editClassId}/{displayKey}/{editKey}/?provider={provider}")]
        public bool DeleteResource(string displayUICulture, string editUICulture, Guid displayClassId, Guid editClassId, string displayKey, string editKey, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{displayUICulture}/{editUICulture}/{displayClassId}/{editClassId}/{displayKey}/{editKey}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("displayUICulture", displayUICulture);
            request.AddUrlSegment("editUICulture", editUICulture);
            request.AddUrlSegment("displayClassId", displayClassId.ToString());
            request.AddUrlSegment("editClassId", editClassId.ToString());
            request.AddUrlSegment("displayKey", displayKey);
            request.AddUrlSegment("editKey", editKey);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebGet(UriTemplate = "{displayUICulture}/{editUICulture}/{displayClassId}/{editClassId}/{displayKey}/{editKey}/?provider={provider}")]
        public DualResourceEntry GetResource(string displayUICulture, string editUICulture, Guid displayClassId, Guid editClassId, string displayKey, string editKey, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{displayUICulture}/{editUICulture}/{displayClassId}/{editClassId}/{displayKey}/{editKey}/?provider={provider}", Method.GET);

            request.AddUrlSegment("displayUICulture", displayUICulture);
            request.AddUrlSegment("editUICulture", editUICulture);
            request.AddUrlSegment("displayClassId", displayClassId.ToString());
            request.AddUrlSegment("editClassId", editClassId.ToString());
            request.AddUrlSegment("displayKey", displayKey);
            request.AddUrlSegment("editKey", editKey);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<DualResourceEntry>(request);
        }

        //[WebGet(UriTemplate = "{displayUICulture=null}/{editUICulture=null}/{displayClassId=null}/{editClassId=null}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<DualResourceEntry> GetResources(string displayUICulture, string editUICulture, Guid displayClassId, Guid editClassId, string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "{displayUICulture}/{editUICulture}/{displayClassId}/{editClassId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("displayUICulture", displayUICulture);
            request.AddUrlSegment("editUICulture", editUICulture);
            request.AddUrlSegment("displayClassId", displayClassId.ToString());
            request.AddUrlSegment("editClassId", editClassId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<DualResourceEntry>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "{displayUICulture}/{editUICulture}/{displayClassId}/{editClassId}/{displayKey}/{editKey}/?provider={provider}")]
        public DualResourceEntry SaveResource(string[][] propertyBag, string displayUICulture, string editUICulture, Guid displayClassId, Guid editClassId, string displayKey, string editKey, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{displayUICulture}/{editUICulture}/{displayClassId}/{editClassId}/{displayKey}/{editKey}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("displayUICulture", displayUICulture);
            request.AddUrlSegment("editUICulture", editUICulture);
            request.AddUrlSegment("displayClassId", displayClassId.ToString());
            request.AddUrlSegment("editClassId", editClassId.ToString());
            request.AddUrlSegment("displayKey", displayKey);
            request.AddUrlSegment("editKey", editKey);
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(propertyBag), ParameterType.RequestBody);

            return ExecuteRequestFor<DualResourceEntry>(request);
        }
    }
}
