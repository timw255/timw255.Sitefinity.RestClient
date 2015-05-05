using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MappingViewModel
    {
        public string ApplicationName { get; set; }
        public string DefaultValue { get; set; }
        public string DestinationPropertyName { get; set; }
        public Guid Id { get; set; }
        public bool IsRequired { get; set; }
        public string[] SourcePropertyNames { get; set; }
        public List<PipeMappingTranslationViewModel> Translations { get; set; }

        public MappingViewModel() { }
    }
}
