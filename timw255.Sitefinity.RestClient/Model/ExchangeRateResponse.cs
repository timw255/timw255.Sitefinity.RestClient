using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ExchangeRateResponse
    {
        public string BaseCurrency { get; set; }
        public List<string> Errors { get; set; }
        public ExchangeRateSuccessType RateRequestStatus { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string ReceivedDateFormatted { get; set; }

        public ExchangeRateResponse() { }
    }
}
