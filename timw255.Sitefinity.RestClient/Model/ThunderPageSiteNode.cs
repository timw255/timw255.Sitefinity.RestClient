using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ThunderPageSiteNode
    {
        public ICollection<ThunderPageSiteNode> ChildNodes { get; set; }
        public Guid Id { get; set; }
        public bool IsMenuPageSection { get; set; }
        public string Title { get; set; }

        public ThunderPageSiteNode() { }
    }
}
