using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class TaxViewModel
    {
        public CultureInfo[] AvailableCultures { get; set; }
        public string[] AvailableLanguages { get; set; }
        public Guid Id { get; set; }
        public string LocationString { get; set; }
        public decimal TaxRate { get; set; }
        public string Title { get; set; }

        public TaxViewModel() { }
    }
}
