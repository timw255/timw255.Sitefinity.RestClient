using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.SiteSync;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class TargetServerInfo
    {
        [DataMember]
        public bool IsMultiSite { get; set; }

        [DataMember]
        public Dictionary<string, SiteSyncSiteInfo> Sites { get; set; }

        public TargetServerInfo()
        {
            this.Sites = new Dictionary<string, SiteSyncSiteInfo>();
        }
    }
}
