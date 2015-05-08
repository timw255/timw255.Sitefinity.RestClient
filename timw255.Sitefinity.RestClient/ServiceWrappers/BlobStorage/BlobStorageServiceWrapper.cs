using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.BlobStorage
{
    public class BlobStorageServiceWrapper : ServiceWrapper
    {
        public BlobStorageServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/BlobStorage/BlobStorage.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "providers/batch/")]
        public bool BatchDeleteProviders(string[] providers)
        {
            var request = new RestRequest(this.ServiceUrl + "providers/batch/", Method.POST);

            request.AddParameter("application/json", SerializeObject(providers), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "providerstats/?libraryType={libraryType}&provider={provider}")]
        public CollectionContext<WcfBlobStorageProvider> GetBlobStorageProviderStats(string libraryType, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "providerstats/?libraryType={libraryType}&provider={provider}", Method.GET);

            request.AddUrlSegment("libraryType", libraryType);
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<CollectionContext<WcfBlobStorageProvider>>(request);
        }

        //[WebGet(UriTemplate = "providers/")]
        public CollectionContext<DataProviderSettingsViewModel> GetProviders()
        {
            var request = new RestRequest(this.ServiceUrl + "providers/", Method.GET);

            return ExecuteRequest<CollectionContext<DataProviderSettingsViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "setdefault/")]
        public bool SetDefault(string newDefaultProvider)
        {
            var request = new RestRequest(this.ServiceUrl + "setdefault/", Method.PUT);

            request.AddParameter("application/json", newDefaultProvider, ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }
    }
}
