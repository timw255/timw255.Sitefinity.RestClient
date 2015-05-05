using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CustomerMoney
    {
        public string Currency { get; set; }
        public string CurrencyInfo { get; set; }
        public string CustomerMoneySpent { get; set; }
        public Guid Id { get; set; }
        public decimal Total { get; set; }

        public CustomerMoney() { }
    }
}
