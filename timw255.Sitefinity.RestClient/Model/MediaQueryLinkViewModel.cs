using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MediaQueryLinkViewModel
    {
        public Guid ItemId { get; set; }
        public string ItemType { get; set; }
        public string LinkType { get; set; }
        public MediaQueryViewModel[] MediaQueries { get; set; }

        public MediaQueryLinkViewModel() { }
    }
}
