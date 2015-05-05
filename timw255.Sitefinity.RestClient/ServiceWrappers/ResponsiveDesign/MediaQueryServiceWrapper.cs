using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.ResponsiveDesign
{
    public class MediaQueryServiceWrapper : ServiceWrapper
    {
        public MediaQueryServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/ResponsiveDesign/MediaQuery.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}")]
        public bool BatchDeleteMediaQueries(Guid[] mediaQueryIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(mediaQueryIds), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{mediaQueryId}/?provider={provider}")]
        public bool DeleteMediaQuery(Guid mediaQueryId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{mediaQueryId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("mediaQueryId", mediaQueryId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<MediaQueryViewModel> GetMediaQueries(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<MediaQueryViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/{mediaQueryId}/?provider={providerName}")]
        public ItemContext<MediaQueryViewModel> GetMediaQuery(Guid mediaQueryId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{mediaQueryId}/?provider={providerName}", Method.GET);

            request.AddUrlSegment("mediaQueryId", mediaQueryId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequestFor<ItemContext<MediaQueryViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{mediaQueryId}/?provider={provider}&itemType={itemType}")]
        public ItemContext<MediaQueryViewModel> SaveMediaQuery(Guid mediaQueryId, ItemContext<MediaQueryViewModel> mediaQuery, string provider, string itemType)
        {
            var request = new RestRequest(this.ServiceUrl + "/{mediaQueryId}/?provider={provider}&itemType={itemType}", Method.PUT);

            request.AddUrlSegment("mediaQueryId", mediaQueryId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("itemType", itemType);

            request.AddParameter("application/json", SerializeObject(mediaQuery), ParameterType.RequestBody);

            return ExecuteRequestFor<ItemContext<MediaQueryViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/mql/?provider={provider}")]
        public ItemContext<MediaQueryLinkViewModel> SaveMediaQueryLink(ItemContext<MediaQueryLinkViewModel> mediaQueryLink, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/mql/?provider={provider}", Method.PUT);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(mediaQueryLink), ParameterType.RequestBody);

            return ExecuteRequestFor<ItemContext<MediaQueryLinkViewModel>>(request);
        }
    }
}
