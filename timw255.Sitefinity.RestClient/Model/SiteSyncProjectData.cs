using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class SiteSyncProjectData
    {
        [DataMember]
        public int IncrementalGuidRange { get; set; }

        [DataMember]
        public bool IsMultisite { get; set; }

        [DataMember]
        public Version SitefinityVersion { get; set; }

        [DataMember]
        public Dictionary<string, string[]> Sites { get; set; }

        public SiteSyncProjectData() { }
    }
}
