using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class RoleProviderPair
    {
        public string ProviderName { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }

        public RoleProviderPair() { }
    }
}
