using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Modules.News.Web.Services;
using Telerik.Sitefinity.News.Model;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Content
{
    public class NewsItemServiceWrapper : ContentServiceWrapper<NewsItem, NewsItemViewModel>
    {
        public NewsItemServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/NewsItemService.svc/";
            this.SF = sf;
        }
    }
}
