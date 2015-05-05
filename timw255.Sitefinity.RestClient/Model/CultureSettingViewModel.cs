using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CultureSettingViewModel
    {
        public string DisplayName { get; set; }
        public bool IsDefault { get; set; }
        public string Key { get; set; }
        public string Setting { get; set; }

        public CultureSettingViewModel() { }
    }
}
