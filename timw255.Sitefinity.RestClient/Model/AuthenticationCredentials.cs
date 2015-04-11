using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class AuthenticationCredentials
    {
        public string MembershipProvider { get; set; }
        public string Password { get; set; }
        public bool Persistent { get; set; }
        public string UserName { get; set; }

        public AuthenticationCredentials() { }
    }
}
