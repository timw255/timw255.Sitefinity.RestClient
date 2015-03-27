using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Modules.Libraries.Videos;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Content
{
    public class VideoServiceWrapper : ContentServiceWrapper<Video, VideoLibraryItemViewModel>
    {
        public VideoServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/VideoService.svc/";
            this.SF = sf;
        }
    }
}
