using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ExchangeRateResponseViewModel
    {
        public string CurrentDefaultCurrency { get; set; }
        public ExchangeRateResponse RateResponse { get; set; }

        public ExchangeRateResponseViewModel() { }
    }
}
