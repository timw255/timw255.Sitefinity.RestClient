using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.GenericContent.Web.Services.Data;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Content;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class CommentsGenericServiceWrapper : ContentServiceWrapper<Comment, CommentsViewModel>
    {
        public CommentsGenericServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/CommentsGenericService.svc/";
            this.SF = sf;
        }
    }
}
