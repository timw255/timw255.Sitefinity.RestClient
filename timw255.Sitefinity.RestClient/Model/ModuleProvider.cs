using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ModuleProvider
    {
        public bool IsSelectedProvider { get; set; }
        public string ManagerTypeName { get; set; }
        public string PermissionSetName { get; set; }
        public string ProviderName { get; set; }
        public string ProviderTitle { get; set; }
        public string SecuredObjectRootId { get; set; }
        public string SecuredObjectType { get; set; }

        public ModuleProvider() { }
    }
}
