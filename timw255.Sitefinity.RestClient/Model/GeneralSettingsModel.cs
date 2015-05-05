using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [Obsolete("Use TimeZoneSettingsContract instead.")]
    public class GeneralSettingsModel
    {
        public string CurrentTimeZoneId { get; set; }
        public string ProjectName { get; set; }
        public string SiteId { get; set; }
        public bool SupportsDaylightSavingTime { get; set; }

        public GeneralSettingsModel() { }
    }
}
