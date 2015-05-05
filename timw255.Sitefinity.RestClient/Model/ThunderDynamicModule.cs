using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ThunderDynamicModule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public ThunderDynamicModuleType[] Types { get; set; }
        public string UrlName { get; set; }

        public ThunderDynamicModule() { }
    }
}
