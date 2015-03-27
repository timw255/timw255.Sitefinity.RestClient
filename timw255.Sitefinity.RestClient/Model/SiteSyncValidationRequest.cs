using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class SiteSyncValidationRequest
    {
        [DataMember]
        public bool IsMigration { get; set; }

        [DataMember]
        public SiteSyncProjectData ProjectData { get; set; }

        [DataMember]
        public Dictionary<string, string> SnapInData { get; set; }

        [DataMember]
        public string TargetMicrositeName { get; set; }

        public SiteSyncValidationRequest() { }
    }
}
