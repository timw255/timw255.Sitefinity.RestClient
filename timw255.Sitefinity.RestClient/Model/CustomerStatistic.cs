using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CustomerStatistic
    {
        public Guid Id { get; set; }
        public DateTime LastOrderDate { get; set; }
        public int LastOrderNumber { get; set; }
        public int OrdersCount { get; set; }

        public CustomerStatistic() { }
    }
}
