using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPermission : IComparable<WcfPermission>
    {
        public string ActionName { get; set; }
        public string ActionTitle { get; set; }
        public string AllowControlClientID { get; set; }
        public string DataProviderName { get; set; }
        public string DenyControlClientID { get; set; }
        public bool IsAllowed { get; set; }
        public bool IsDenied { get; set; }
        public string PermissionSetName { get; set; }
        public string PrincipalID { get; set; }
        public string PrincipalName { get; set; }
        public string PrincipalTitle { get; set; }
        public string PrincipalType { get; set; }
        public string SecuredObjectId { get; set; }

        public WcfPermission() { }

        public int CompareTo(WcfPermission other)
        {
            return this.PrincipalTitle.CompareTo(other.PrincipalTitle);
        }
    }
}
