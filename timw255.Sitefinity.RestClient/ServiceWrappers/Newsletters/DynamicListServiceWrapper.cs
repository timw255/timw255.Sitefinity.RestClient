using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Newsletters
{
    public class DynamicListServiceWrapper : ServiceWrapper
    {
        public DynamicListServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Newsletters/DynamicList.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "/info/{dynamicListProviderName}/")]
        public CollectionContext<DynamicListInfoViewModel> GetDynamicListsInfo(string dynamicListProviderName)
        {
            var request = new RestRequest(this.ServiceUrl + "/info/{dynamicListProviderName}/", Method.GET);

            request.AddUrlSegment("dynamicListProviderName", dynamicListProviderName);

            return ExecuteRequest<CollectionContext<DynamicListInfoViewModel>>(request);
        }
    }
}
