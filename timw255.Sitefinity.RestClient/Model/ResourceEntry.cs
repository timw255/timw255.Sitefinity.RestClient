using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ResourceEntry
    {
        public bool BuiltIn { get; set; }
        public string ClassId { get; set; }
        public string CultureDisplayName { get; set; }
        public string CultureName { get; set; }
        public virtual string Description { get; set; }
        public string Key { get; set; }
        public DateTime LastModified { get; set; }
        public virtual string Value { get; set; }

        public ResourceEntry() { }
    }
}
