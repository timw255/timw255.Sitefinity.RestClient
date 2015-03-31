using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Blogs.Model;
using Telerik.Sitefinity.Modules.Blogs.Web.Services;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class BlogPostServiceWrapper : ContentServiceWrapper<BlogPost, BlogPostViewModel>
    {
        public BlogPostServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/BlogPostService.svc/";
            this.SF = sf;
        }
    }
}
