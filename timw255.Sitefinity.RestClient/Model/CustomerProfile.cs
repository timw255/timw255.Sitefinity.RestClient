using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [Obsolete("This class is obsolete, please use Customer Address to get user profile related information. This class will be removed in 5.3")]
    public class CustomerProfile : UserProfile
    {
        public string ShippingAddress1 { get; set; }

        public CustomerProfile() { }
    }
}
