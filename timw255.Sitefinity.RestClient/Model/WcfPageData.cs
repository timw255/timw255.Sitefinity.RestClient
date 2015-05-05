using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPageData
    {
        public DateTime? ExpirationDate { get; set; }
        public Guid PageNodeId { get; set; }
        public DateTime PublicationDate { get; set; }

        public WcfPageData() { }
    }
}
