using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfBlobStorageProvider
    {
        public string ApplicationName { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int TotalItemsCount { get; set; }

        public WcfBlobStorageProvider() { }
    }
}
