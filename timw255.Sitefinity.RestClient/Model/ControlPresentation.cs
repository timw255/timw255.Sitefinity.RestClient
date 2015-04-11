using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ControlPresentation : PresentationData
    {
        public string AreaName { get; set; }
        public string Condition { get; set; }
        public string ControlType { get; set; }
        public string EmbeddedTemplateName { get; set; }
        public string FriendlyControlName { get; set; }
        public bool IsDifferentFromEmbedded { get; set; }
        public string NameForDevelopers { get; set; }
        public string ResourceAssemblyName { get; set; }
        public string ResourceClassId { get; set; }

        public ControlPresentation() { }
    }
}
