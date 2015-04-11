using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DynamicListSettingsViewModel
    {
        public string ConnectionName { get; set; }
        public string DynamicListProviderName { get; set; }
        public string EmailMappedField { get; set; }
        public string FirstNameMappedField { get; set; }
        public string LastNameMappedField { get; set; }
        public string ListKey { get; set; }

        public DynamicListSettingsViewModel() { }
    }
}
