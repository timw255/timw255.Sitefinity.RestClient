using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Modules.Libraries.Images;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Content
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
