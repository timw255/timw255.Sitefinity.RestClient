using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SitefinityProfile : UserProfile
    {
        public string __type
        {
            get
            {
                return "Telerik.Sitefinity.Security.Model.SitefinityProfile";
            }
            set { }
        }
        public string About { get; set; }
        public ContentLink Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        [Obsolete("Will be removed when user settings a re implemented")]
        public string PreferredLanguage { get; set; }

        public SitefinityProfile() { }
    }
}
