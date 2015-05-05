using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPermissionSetPermission
    {
        public string ActionDescription { get; set; }
        public string ActionName { get; set; }
        public string ActionTitle { get; set; }
        public WcfPermission[] Permissions { get; set; }
        public string PermissionSetName { get; set; }
        public string ProviderId { get; set; }

        public WcfPermissionSetPermission() { }
    }
}
