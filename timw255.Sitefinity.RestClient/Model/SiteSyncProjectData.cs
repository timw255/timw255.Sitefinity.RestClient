using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SiteSyncProjectData
    {
        public int IncrementalGuidRange { get; set; }
        public bool IsMultisite { get; set; }
        public Version SitefinityVersion { get; set; }
        public Dictionary<string, string[]> Sites { get; set; }

        public SiteSyncProjectData() { }
    }
}
