using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PolicyItem
    {
        public bool HasConfig { get; set; }
        public string PolicyHandlerName { get; set; }
        public string PolicyName { get; set; }

        public PolicyItem() { }
    }
}
