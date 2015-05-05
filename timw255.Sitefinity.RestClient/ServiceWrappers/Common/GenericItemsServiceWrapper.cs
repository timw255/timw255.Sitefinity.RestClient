using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Common
{
    public class GenericItemsServiceWrapper : ServiceWrapper
    {
        public GenericItemsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Common/GenericItemsService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/?itemType={itemType}&itemSurrogateType={itemSurrogateType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&allProviders={allProviders}&ignoreAdminUsers={ignoreAdminUsers}")]
        public CollectionContext<WcfItemBase> GetGenericItems(string itemType, string itemSurrogateType, string sortExpression, int skip, int take, string filter, string providerName, bool allProviders, bool ignoreAdminUsers)
        {
            var request = new RestRequest(this.ServiceUrl + "/?itemType={itemType}&itemSurrogateType={itemSurrogateType}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={providerName}&allProviders={allProviders}&ignoreAdminUsers={ignoreAdminUsers}", Method.GET);

            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("itemSurrogateType", itemSurrogateType);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("allProviders", allProviders.ToString());
            request.AddUrlSegment("ignoreAdminUsers", ignoreAdminUsers.ToString());

            return ExecuteRequestFor<CollectionContext<WcfItemBase>>(request);
        }
    }
}
