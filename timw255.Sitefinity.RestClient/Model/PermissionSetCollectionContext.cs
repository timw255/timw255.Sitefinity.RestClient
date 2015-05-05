using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PermissionSetCollectionContext : CollectionContext<WcfPermissionSetPermission>
    {
        public bool CanInheritPermissions { get; set; }
        public string[] EditablePermissionSets { get; set; }
        public bool InheritsPermissions { get; set; }
        public bool isCurrentPrincipalAdministrator { get; set; }
        public Guid SecuredObjectId { get; set; }

        public PermissionSetCollectionContext() { }
    }
}
