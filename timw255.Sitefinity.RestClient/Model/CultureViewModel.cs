using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CultureViewModel
    {
        public string Culture { get; set; }
        public string DisplayName { get; set; }
        public string FieldSuffix { get; set; }
        public bool IsDefault { get; set; }
        public string Key { get; set; }
        public string ShortName { get; set; }
        public string[] SitesNames { get; set; }
        public string[] SitesUsingCultureAsDefault { get; set; }
        public string UICulture { get; set; }

        public CultureViewModel() { }
    }
}
