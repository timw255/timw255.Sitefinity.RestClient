using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Lists
{
    public class ListsModuleServiceWrapper : ServiceWrapper
    {
        public ListsModuleServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Lists/ListsModuleService.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "FullSummary/?listItemId={listItemId}")]
        public string GetFullSummary(Guid listItemId)
        {
            var request = new RestRequest(this.ServiceUrl + "FullSummary/?listItemId={listItemId}", Method.GET);

            request.AddUrlSegment("listItemId", listItemId.ToString());

            return ExecuteRequest<string>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "Set/SortOrder/{listId}/{sortOrder}/", ResponseFormat = WebMessageFormat.Xml)]
        public void SetListSortOrder(Guid listId, string sortOrder)
        {
            var request = new RestRequest(this.ServiceUrl + "Set/SortOrder/{listId}/{sortOrder}/", Method.POST);

            request.AddUrlSegment("listId", listId.ToString());
            request.AddUrlSegment("sortOrder", sortOrder);

            ExecuteRequest(request);
        }
    }
}
