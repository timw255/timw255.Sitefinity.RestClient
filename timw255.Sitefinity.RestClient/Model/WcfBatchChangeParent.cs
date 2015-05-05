using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfBatchChangeParent
    {
        public Guid NewParentId { get; set; }
        public Guid[] TaxonIds { get; set; }

        public WcfBatchChangeParent() { }
    }
}
