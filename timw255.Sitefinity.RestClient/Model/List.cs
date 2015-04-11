using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class List : ContentBase
    {
        public Guid LandingPageId { get; set; }
        public string SortOrder { get; set; }

        public List() { }
    }
}
