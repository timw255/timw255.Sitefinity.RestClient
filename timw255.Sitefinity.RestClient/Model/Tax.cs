using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Tax : IDynamicFieldsContainer
    {
        public AddressType AddressType { get; set; }
        public bool ApplyTaxToShipping { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string FromZip { get; set; }
        public Guid Id { get; set; }
        [Obsolete]
        public bool IncludeTaxInPrice { get; set; }
        public string LocationString { get; set; }
        public Guid Owner { get; set; }
        public decimal StandardTaxRate { get; set; }
        public string State { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public decimal TaxRate { get; set; }
        public List<TaxClassRate> TaxRateCollection { get; set; }
        public string TaxRates { get; set; }
        public string TaxZipRangeJson { get; set; }
        public Lstring Title { get; set; }
        public string ToZip { get; set; }
        public bool UseZipRange { get; set; }
        public int Version { get; set; }
        public bool Visible { get; set; }

        public Tax() { }
    }
}
