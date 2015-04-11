using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SummaryItemSiteDetails
    {
        public string SiteId { get; set; }
        public List<SummaryItemTypeDetails> SummaryItemTypesDetails { get; set; }

        public SummaryItemSiteDetails() { }
    }
}
