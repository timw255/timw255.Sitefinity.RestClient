using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class UserProviderPair
    {
        public string ProviderName { get; set; }
        public bool Remove { get; set; }
        public Guid UserId { get; set; }

        public UserProviderPair() { }
    }
}
