using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public abstract class Price
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public long Quantity { get; set; }
        public decimal Value { get; set; }

        protected Price() { }
    }
}
