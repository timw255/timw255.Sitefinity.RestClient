using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class UserProfileInfo
    {
        public DateTime DateCreated { get; set; }
        public Guid Id { get; set; }
        public Guid Owner { get; set; }

        public UserProfileInfo() { }
    }
}
