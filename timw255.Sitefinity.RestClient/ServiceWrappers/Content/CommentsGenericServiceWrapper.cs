using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.ServiceWrappers.Content;

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
