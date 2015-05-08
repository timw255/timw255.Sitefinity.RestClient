using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers
{
    public class Html5UploadHandlerWrapper : ServiceWrapper
    {
        public Html5UploadHandlerWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Telerik.Sitefinity.Html5UploadHandler.ashx";
            this.SF = sf;
        }

        public UploadResponse UploadContent(Guid parentId, Guid contentId, byte[] contentData, string fileName, string contentType, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl, Method.POST);

            request.AddParameter("ContentType", contentType);
            request.AddParameter("LibraryId", parentId.ToString());
            request.AddParameter("ContentId", contentId.ToString());
            request.AddParameter("Workflow", "Upload");
            request.AddParameter("ProviderName", providerName);

            request.AddFile("uploadInput", contentData, fileName, "application/octet-stream");

            return ExecuteRequest<UploadResponse[]>(request).First();
        }
    }
}
