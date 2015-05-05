using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ModuleEditorContext
    {
        public IDictionary<string, WcfField> AddFields { get; set; }
        public string ContentType { get; set; }
        public IList<string> RemoveFields { get; set; }

        public ModuleEditorContext() { }
    }
}
