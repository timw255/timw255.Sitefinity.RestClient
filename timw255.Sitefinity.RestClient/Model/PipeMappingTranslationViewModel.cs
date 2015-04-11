using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PipeMappingTranslationViewModel
    {
        public Guid Id { get; set; }
        public string TranslatorName { get; set; }
        public string TranslatorSettings { get; set; }

        public PipeMappingTranslationViewModel() { }
    }
}
