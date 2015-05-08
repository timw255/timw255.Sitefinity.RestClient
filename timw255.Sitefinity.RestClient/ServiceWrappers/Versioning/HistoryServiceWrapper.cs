using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Versioning
{
    public class HistoryServiceWrapper : ServiceWrapper
    {
        public HistoryServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Versioning/HistoryService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{changeId}/")]
        public bool DeleteChange(Guid changeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/{changeId}/", Method.DELETE);

            request.AddUrlSegment("changeId", changeId.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/?itemType={itemType}&itemId={itemId}")]
        public CollectionContext<WcfChange> GetItemVersionHistory(string itemType, Guid itemId)
        {
            var request = new RestRequest(this.ServiceUrl + "/?itemType={itemType}&itemId={itemId}", Method.GET);

            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("itemId", itemId.ToString());

            return ExecuteRequest<CollectionContext<WcfChange>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{changeId}/")]
        public bool SaveChangeComment(string comment, Guid changeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/{changeId}/", Method.PUT);

            request.AddUrlSegment("changeId", changeId.ToString());

            request.AddParameter("application/json", SerializeObject(comment), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }
    }
}
