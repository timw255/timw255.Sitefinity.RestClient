using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
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
