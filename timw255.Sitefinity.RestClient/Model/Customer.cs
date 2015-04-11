using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Customer : IDynamicFieldsContainer
    {
        public CultureInfo CurrencyCultureInfo { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerName { get; set; }
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string LastOrderDate { get; set; }
        public string LastOrderNumber { get; set; }
        public string MoneySpent { get; set; }
        public IList<Order> Orders { get; set; }
        public string OrdersCount { get; set; }
        public Guid StatisticId { get; set; }
        public Guid? UserProfileId { get; set; }
        public UserProfileInfo UserProfileInfo { get; set; }

        public Customer() { }
    }
}
