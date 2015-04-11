using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class RoleProviderItem
    {
        public long NumOfRoles { get; set; }
        public string RoleProviderName { get; set; }
        public string RoleProviderTitle { get; set; }

        public RoleProviderItem() { }
    }
}
