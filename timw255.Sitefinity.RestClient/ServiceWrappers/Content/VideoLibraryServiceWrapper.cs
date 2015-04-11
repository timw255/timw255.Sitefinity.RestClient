using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class VideoLibraryServiceWrapper : ContentServiceWrapper<VideoLibrary, LibraryViewModel>
    {
        public VideoLibraryServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/VideoLibraryService.svc/";
            this.SF = sf;
        }
    }
}