using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WebsiteTemplate
    {
        public byte[] Data { get; set; }
        public IEnumerable<MasterPageFile> MasterPages { get; set; }
        public string Name { get; set; }
        public IEnumerable<Theme> Themes { get; set; }

        public WebsiteTemplate() { }
    }
}
