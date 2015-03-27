using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Modules.Libraries.Web.Services;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Content
{
    public class AlbumServiceWrapper : ContentServiceWrapper<Album, AlbumViewModel>
    {
        public AlbumServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/AlbumService.svc/";
            this.SF = sf;
        }
    }
}
