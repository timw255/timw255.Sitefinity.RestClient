using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Localization
{
    public class LocalizationClassesServiceWrapper : ServiceWrapper
    {
        public LocalizationClassesServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Localization/LocalizationClasses.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={provider}")]
        public CollectionContext<string> GetClasses(string sortExpression, int skip, int take, string filter, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "?sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&provider={provider}", Method.GET);

            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<CollectionContext<string>>(request);
        }
    }
}
