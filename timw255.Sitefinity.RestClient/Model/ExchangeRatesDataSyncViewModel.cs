using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ExchangeRatesDataSyncViewModel
    {
        public Guid ServiceId { get; set; }
        public CurrencyExchangeDataSync Sync { get; set; }
        public ExchangeRateServiceSyncWhen SyncWhen { get; set; }

        public ExchangeRatesDataSyncViewModel() { }
    }
}
