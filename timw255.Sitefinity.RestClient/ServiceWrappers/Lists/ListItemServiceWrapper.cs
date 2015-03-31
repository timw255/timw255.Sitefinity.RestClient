using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Lists.Model;
using Telerik.Sitefinity.Modules.Lists.Web.Services.Data;
using timw255.Sitefinity.RestClient.ServiceWrappers.Content;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Lists
{
    public class ListItemServiceWrapper : ContentServiceWrapper<ListItem, ListItemViewModel>
    {
        public ListItemServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Lists/ListItemService.svc/";
            this.SF = sf;
        }
    }
}
