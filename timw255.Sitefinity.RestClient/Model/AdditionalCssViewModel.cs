using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class AdditionalCssViewModel
    {
        public string CssFilePath { get; set; }
        public bool InheritDefaultTheme { get; set; }

        public AdditionalCssViewModel() { }
    }
}
