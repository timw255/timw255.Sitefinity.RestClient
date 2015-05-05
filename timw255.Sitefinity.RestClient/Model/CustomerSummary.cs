using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CustomerSummary
    {
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string ImageUrl { get; set; }
        public Guid ProfileId { get; set; }

        public CustomerSummary(Customer customer) { }
    }
}
