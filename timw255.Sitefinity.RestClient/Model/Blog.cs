using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Blog : ContentBase
    {
        public override DateTime? ExpirationDate { get; set; }
        public Lstring ItemDefaultUrl { get; set; }
        public Guid LandingPageId { get; set; }

        public Blog() { }
    }
}
