using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class ImageServiceWrapper : ContentServiceWrapper<Image, AlbumItemViewModel>
    {
        public ImageServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/ImageService.svc/";
            this.SF = sf;
        }
    }
}
