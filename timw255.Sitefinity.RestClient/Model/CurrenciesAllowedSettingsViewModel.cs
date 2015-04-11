using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CurrenciesAllowedSettingsViewModel
    {
        public CurrencyViewModel[] Currencies { get; set; }
        public ExchangeRatesDataSyncViewModel DataSyncOptions { get; set; }
        public string LastSyncCurrency { get; set; }
        public DateTime? LastSyncDate { get; set; }
        public string LastSyncDateFormatted { get; set; }

        public CurrenciesAllowedSettingsViewModel() { }
    }
}
