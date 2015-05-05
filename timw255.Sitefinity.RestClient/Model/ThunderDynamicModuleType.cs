using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ThunderDynamicModuleType : MarshalByRefObject
    {
        public string DisplayName { get; set; }
        public string FullTypeName { get; set; }
        public string MainShortTextFieldName { get; set; }
        public Guid ParentModuleId { get; set; }
        public string ParentModuleName { get; set; }
        public string TypeName { get; set; }

        public ThunderDynamicModuleType() { }
    }
}
