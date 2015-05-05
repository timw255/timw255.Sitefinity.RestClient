using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MappingSettingsViewModel
    {
        public string ApplicationName { get; set; }
        public Guid Id { get; set; }
        public List<MappingViewModel> Mappings { get; set; }

        public MappingSettingsViewModel() { }
    }
}
