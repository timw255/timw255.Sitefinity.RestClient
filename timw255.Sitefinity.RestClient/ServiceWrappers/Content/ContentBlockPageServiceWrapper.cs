using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class ContentBlockPageServiceWrapper : ServiceWrapper
    {
        public ContentBlockPageServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/ContentBlockPage.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "/pages/?cultureName={cultureName}")]
        public CollectionContext<ContentBlockPageViewModel> GetContentBlocksByPages(string cultureName)
        {
            var request = new RestRequest(this.ServiceUrl + "/pages/?cultureName={cultureName}", Method.GET);

            request.AddUrlSegment("cultureName", cultureName);

            return ExecuteRequest<CollectionContext<ContentBlockPageViewModel>>(request);
        }
    }
}
