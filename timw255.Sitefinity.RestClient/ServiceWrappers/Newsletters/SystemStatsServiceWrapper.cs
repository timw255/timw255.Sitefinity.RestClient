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
    public class SystemStatsServiceWrapper : ServiceWrapper
    {
        public SystemStatsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Newsletters/SystemStats.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/?provider={provider}")]
        public SystemStats GetStats(string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}", Method.GET);

            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<SystemStats>(request);
        }
    }
}
