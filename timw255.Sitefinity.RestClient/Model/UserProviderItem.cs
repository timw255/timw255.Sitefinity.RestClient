using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class UserProviderItem
    {
        public long NumOfUsers { get; set; }
        public string UserProviderName { get; set; }
        public string UserProviderTitle { get; set; }

        public UserProviderItem() { }
    }
}
