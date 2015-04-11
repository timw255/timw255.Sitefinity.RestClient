using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ControlTemplateViewModel
    {
        public string AreaName { get; set; }
        public string Data { get; set; }
        public string FriendlyUserName { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string SiteLinksString { get; set; }

        public ControlTemplateViewModel() { }
    }
}
