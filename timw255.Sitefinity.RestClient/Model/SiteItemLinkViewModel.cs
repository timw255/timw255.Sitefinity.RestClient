using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SiteItemLinkViewModel
    {
        public bool IsShared { get; set; }
        public Guid SiteId { get; set; }
        public string SiteName { get; set; }

        public SiteItemLinkViewModel() { }
    }
}
