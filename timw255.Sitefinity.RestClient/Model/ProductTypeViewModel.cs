using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductTypeViewModel
    {
        public CultureInfo[] AvailableCultures { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string ClrType { get; set; }
        public Guid Id { get; set; }
        public ProductType Item { get; set; }
        public string ProductDeliveryTypeTitle { get; set; }
        public string Title { get; set; }

        public ProductTypeViewModel() { }
    }
}
