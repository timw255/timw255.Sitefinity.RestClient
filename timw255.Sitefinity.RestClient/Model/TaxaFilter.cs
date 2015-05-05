using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class TaxaFilter
    {
        public string FilterExpression { get; set; }
        public string ItemType { get; set; }
        public string Mode { get; set; }
        public string Provider { get; set; }
        public int Skip { get; set; }
        public string SortExpression { get; set; }
        public int Take { get; set; }

        public TaxaFilter() { }
    }
}
