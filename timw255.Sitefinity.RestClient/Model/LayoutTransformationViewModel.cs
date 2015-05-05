using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class LayoutTransformationViewModel
    {
        public string AlternatLayoutElementName { get; set; }
        public string OriginalLayoutElementName { get; set; }

        public LayoutTransformationViewModel() { }
    }
}
