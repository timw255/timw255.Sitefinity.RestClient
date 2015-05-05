using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ExpandableControlDefinition : DefinitionBase
    {
        public string ControlDefinitionName { get; set; }
        public bool? Expanded { get; set; }
        public string ExpandText { get; set; }
        public string FieldName { get; set; }
        public string ResourceClassId { get; set; }
        public string SectionName { get; set; }
        public string ViewName { get; set; }

        public ExpandableControlDefinition() { }
    }
}
