using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class TargetServerInfo
    {
        public bool IsMultiSite { get; set; }
        public Dictionary<string, SiteSyncSiteInfo> Sites { get; set; }

        public TargetServerInfo() { }
    }
}
