using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DocumentLibrary : Library
    {
        public IEnumerable<ContentBase> ChildContentItems { get; set; }
        public Type ChildItemType { get; set; }
        public string[] SupportedPermissionSets { get; set; }

        public DocumentLibrary() { }
    }
}
