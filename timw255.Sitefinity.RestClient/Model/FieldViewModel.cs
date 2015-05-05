using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class FieldViewModel
    {
        public string ContentType { get; set; }
        public string FieldTypeName { get; set; }
        public bool IsBuiltIn { get; set; }
        public bool IsCustom { get; set; }
        public string Name { get; set; }
        public WcfFieldDefinition RelatedFieldDefinition { get; set; }

        public FieldViewModel() { }
    }
}
