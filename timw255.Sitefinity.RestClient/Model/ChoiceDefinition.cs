using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ChoiceDefinition : DefinitionBase
    {
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool Selected { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }

        public ChoiceDefinition() { }
    }
}
