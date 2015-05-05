using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfTaxonStatistic
    {
        public uint Count { get; set; }
        public string ItemProvider { get; set; }
        public string ItemType { get; set; }
        public string Name { get; set; }

        public WcfTaxonStatistic() { }
    }
}
