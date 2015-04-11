using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProviderMigrationRequest
    {
        public IDictionary<string, IDictionary<string, IDictionary<string, string>>> Providers { get; set; }
        public string SourceSiteName { get; set; }
        public string TargetMicrositeName { get; set; }

        public ProviderMigrationRequest() { }
    }
}
