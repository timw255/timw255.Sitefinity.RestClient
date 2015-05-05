using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfMarketContentItem
    {
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid Id { get; set; }
        public string Owner { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public WcfMarketContentItem() { }
    }
}
