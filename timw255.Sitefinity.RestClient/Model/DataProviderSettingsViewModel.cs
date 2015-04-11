using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DataProviderSettingsViewModel
    {
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool HasSettings { get; set; }
        public string Id { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public string ProviderType { get; set; }
        public string ProviderTypeTitle { get; set; }
        public string Title { get; set; }

        public DataProviderSettingsViewModel() { }
    }
}
