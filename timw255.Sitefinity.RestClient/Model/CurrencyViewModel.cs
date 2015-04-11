using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CurrencyViewModel
    {
        public string CountryCurrencyName { get; set; }
        public string CountryIsoCode { get; set; }
        public string CountryName { get; set; }
        public string DefaultCurrency { get; set; }
        public string DisplayCountryCurrencyName { get; set; }
        public string DisplayName { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsDefault { get; set; }
        public string Key { get; set; }
        public CurrencyRounding RoundToTheNearest { get; set; }

        public CurrencyViewModel() { }
    }
}
