using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class TaxClassRate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public bool TaxExempt { get; set; }

        public TaxClassRate() { }
    }
}
