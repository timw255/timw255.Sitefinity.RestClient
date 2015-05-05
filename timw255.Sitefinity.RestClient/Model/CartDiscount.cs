using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CartDiscount : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountAmountDisplay { get; set; }
        public DiscountAmountType DiscountAmountType { get; set; }
        public DiscountType DiscountType { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public decimal SavingsAmount { get; set; }
        public string SavingsAmountFormatted { get; set; }
        public Lstring Title { get; set; }

        public CartDiscount() { }
    }
}
