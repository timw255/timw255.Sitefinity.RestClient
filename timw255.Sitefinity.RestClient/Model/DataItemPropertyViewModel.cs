using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DataItemPropertyViewModel
    {
        public string ControlTag { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }

        public DataItemPropertyViewModel() { }
    }
}
