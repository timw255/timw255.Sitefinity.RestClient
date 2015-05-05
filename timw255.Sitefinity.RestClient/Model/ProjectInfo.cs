using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProjectInfo
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string SfVersion { get; set; }
        public string Version { get; set; }

        public ProjectInfo() { }
    }
}
