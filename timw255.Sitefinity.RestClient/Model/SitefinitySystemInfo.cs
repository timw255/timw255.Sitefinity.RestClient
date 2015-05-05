using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SitefinitySystemInfo
    {
        public ThunderAuthenticationMode AuthenticationMode { get; set; }
        public List<string> MembershipProviders { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectName { get; set; }
        public string ProjectVersion { get; set; }
        public string ThunderModuleVersion { get; set; }
        public string Version { get; set; }

        public SitefinitySystemInfo() { }
    }
}
