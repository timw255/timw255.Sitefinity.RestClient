using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.GenericContent.Web.Services;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Content;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Common
{
    public class ContentServiceWrapper : ContentServiceWrapper<ContentItem, ContentViewModel>
    {
        public ContentServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Common/Content.svc/";
            this.SF = sf;
        }
    }
}
