using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DataItemProperty
    {
        public string ControlTag { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public DataItemPropertyType Type { get; set; }

        public DataItemProperty() { }
    }
}
