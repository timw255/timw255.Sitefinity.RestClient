using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DynamicListInfoViewModel
    {
        public IList<MergeTagViewModel> AvailableProperties { get; set; }
        public string Key { get; set; }
        public string ProviderName { get; set; }
        public string Title { get; set; }

        public DynamicListInfoViewModel() { }
    }
}
