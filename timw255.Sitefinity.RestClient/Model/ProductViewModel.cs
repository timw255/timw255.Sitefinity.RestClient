using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductViewModel
    {
        public CultureInfo[] AvailableCultures { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string EditCommandName { get; set; }
        public Guid Id { get; set; }
        public Product Item { get; set; }
        public string Owner { get; set; }
        public string ProductTypeTitle { get; set; }
        public string Status { get; set; }
        public string UIStatus { get; set; }
        public int VariationCount { get; set; }

        public ProductViewModel() { }
    }
}
