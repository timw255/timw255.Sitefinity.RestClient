using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MergeTagViewModel
    {
        public string ComposedTag { get; set; }
        public string DeclaringTypeName { get; set; }
        public string PropertyName { get; set; }
        public string Title { get; set; }

        public MergeTagViewModel() { }
    }
}
