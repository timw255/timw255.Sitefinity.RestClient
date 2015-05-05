using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfRole : WcfItemBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public string ProviderTitle { get; set; }
        public int UsersInRole { get; set; }

        public WcfRole() { }
    }
}
