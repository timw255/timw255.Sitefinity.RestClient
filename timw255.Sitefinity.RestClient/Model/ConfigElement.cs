using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ConfigElement
    {
        public string CollectionItemName { get; set; }
        public ConfigElement Parent { get; set; }
        public ConfigPropertyCollection Properties { get; set; }
        public ConfigSection Section { get; set; }
        public string TagName { get; set; }

        static ConfigElement() { }
    }
}
