using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class ProviderMigrationRequest
    {
        [DataMember]
        public IDictionary<string, IDictionary<string, IDictionary<string, string>>> Providers { get; set; }

        [DataMember]
        public string SourceSiteName { get; set; }

        [DataMember]
        public string TargetMicrositeName { get; set; }

        public ProviderMigrationRequest()
        {
            this.Providers = new Dictionary<string, IDictionary<string, IDictionary<string, string>>>();
        }
    }
}
