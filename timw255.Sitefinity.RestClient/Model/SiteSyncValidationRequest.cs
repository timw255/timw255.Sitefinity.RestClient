using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SiteSyncValidationRequest
    {
        public bool IsMigration { get; set; }
        public SiteSyncProjectData ProjectData { get; set; }
        public Dictionary<string, string> SnapInData { get; set; }
        public string TargetMicrositeName { get; set; }

        public SiteSyncValidationRequest() { }
    }
}
