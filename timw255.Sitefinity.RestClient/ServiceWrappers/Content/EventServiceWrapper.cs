using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Events.Model;
using Telerik.Sitefinity.Modules.Events.Web.Services;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Content
{
    public class EventServiceWrapper : ContentServiceWrapper<Event, EventViewModel>
    {
        public EventServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/EventService.svc/";
            this.SF = sf;
        }
    }
}
