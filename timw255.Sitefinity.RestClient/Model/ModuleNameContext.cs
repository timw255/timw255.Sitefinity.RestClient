using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class ModuleNameContext
    {
        [DataMember]
        public bool IsContained { get; set; }

        public ModuleNameContext() { }
    }
}
