using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Theme
    {
        public byte[] Data { get; set; }
        public string DisplayName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsInFileSystem { get; set; }
        public string Name { get; set; }
        public ThemeType Type { get; set; }
        public string WebsiteTemplateName { get; set; }
        public Theme(string name, ThemeType type) { }

        public Theme() { }
    }
}
