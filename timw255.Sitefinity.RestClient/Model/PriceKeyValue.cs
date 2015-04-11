using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PriceKeyValue
    {
        public string Currency { get; set; }
        public string DisplayRate { get; set; }
        public decimal Rate { get; set; }
        public CurrencyRounding Rounding { get; set; }

        public PriceKeyValue() { }
    }
}
