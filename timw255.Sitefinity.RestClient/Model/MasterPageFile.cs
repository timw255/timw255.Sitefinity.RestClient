using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MasterPageFile
    {
        public string Name { get; set; }
        public string PresentationData { get; set; }
        public string VirtualPath { get; set; }
        public string WebsiteTemplateName { get; set; }

        public MasterPageFile() { }
    }
}
