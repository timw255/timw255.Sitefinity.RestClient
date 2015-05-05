using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class LocalizationSettingsModel
    {
        public CultureViewModel[] BackendCultures { get; set; }
        public CultureViewModel[] Cultures { get; set; }
        public string DefaultLocalizationStrategy { get; set; }
        public CultureSettingViewModel[] DefaultStrategySettings { get; set; }
        public string MonolingualCulture { get; set; }
        [Obsolete("Use DefaultStrategySettings")]
        public CultureSettingViewModel[] SubdomainStrategySettings { get; set; }

        public LocalizationSettingsModel() { }
    }
}
