using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class UserRolesItem
    {
        public RoleProviderPair[] Roles { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

        public UserRolesItem() { }
    }
}
