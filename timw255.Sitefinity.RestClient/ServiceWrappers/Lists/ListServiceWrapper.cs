using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.ServiceWrappers.Content;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Lists
{
    public class ListServiceWrapper : ContentServiceWrapper<List, ListViewModel>
    {
        public ListServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Lists/ListService.svc/";
            this.SF = sf;
        }
    }
}
