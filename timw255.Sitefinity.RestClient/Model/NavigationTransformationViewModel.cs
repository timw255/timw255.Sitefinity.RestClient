using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class NavigationTransformationViewModel
    {
        public string CssClasses { get; set; }
        public string TransformationName { get; set; }

        public NavigationTransformationViewModel() { }
    }
}
