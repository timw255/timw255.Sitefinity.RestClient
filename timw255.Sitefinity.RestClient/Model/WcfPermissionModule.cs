using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPermissionModule
    {
        public string ManagerTypeName { get; set; }
        public string ModuleTitle { get; set; }
        public WcfPermissionProvider[] Providers { get; set; }

        public WcfPermissionModule() { }
    }
}
