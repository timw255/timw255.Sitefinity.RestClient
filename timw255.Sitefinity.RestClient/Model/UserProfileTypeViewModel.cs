using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class UserProfileTypeViewModel
    {
        public string AppliedTo { get; set; }
        public string DynamicTypeName { get; set; }
        public Guid Id { get; set; }
        public MembershipProvidersUsage MembershipProvidersUsage { get; set; }
        public string Name { get; set; }
        public string ProfileProviderName { get; set; }
        public ProviderViewModel[] SelectedMembershipProviders { get; set; }
        public string Title { get; set; }

        public UserProfileTypeViewModel() { }
    }
}
