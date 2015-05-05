using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CultureElement
    {
        public string Culture { get; set; }
        public string DisplayName { get; set; }
        public string UICulture { get; set; }

        public CultureElement() { }
    }
}
