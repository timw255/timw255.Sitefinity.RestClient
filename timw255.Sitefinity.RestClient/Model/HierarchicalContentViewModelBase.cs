using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class HierarchicalContentViewModelBase : ContentViewModelBase
    {
        public string Url { get; set; }

        public HierarchicalContentViewModelBase() { }
    }
}
