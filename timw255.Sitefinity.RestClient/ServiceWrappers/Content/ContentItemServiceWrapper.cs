using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.GenericContent.Web.Services;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class ContentItemServiceWrapper : ContentServiceWrapper<ContentItem, ContentViewModel>
    {
        public ContentItemServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/ContentItemService.svc/";
            this.SF = sf;
        }
    }
}
