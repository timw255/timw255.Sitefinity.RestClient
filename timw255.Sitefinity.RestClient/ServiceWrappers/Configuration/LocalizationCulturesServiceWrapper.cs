using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Localization.Configuration;
using Telerik.Sitefinity.Web.Services;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Configuration
{
    public class LocalizationCulturesServiceWrapper : ServiceWrapper
    {
        public LocalizationCulturesServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Configuration/LocalizationCultures.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={provider}")]
        public CollectionContext<CultureElement> GetCultures(string sortExpression, int skip, int take, string filter, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={provider}", Method.GET);

            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<CollectionContext<CultureElement>>(request);
        }
    }
}
