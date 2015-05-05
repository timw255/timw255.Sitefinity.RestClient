using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPermissionProvider
    {
        public string DynamicDataProviderName { get; set; }
        public string ManagerType { get; set; }
        public string PermissionSetName { get; set; }
        public WcfPermissionSetPermission[] PermissionSets { get; set; }
        public string ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderTitle { get; set; }
        public string SecuredObjectId { get; set; }
        public string SecuredObjectType { get; set; }

        public WcfPermissionProvider() { }
    }
}
