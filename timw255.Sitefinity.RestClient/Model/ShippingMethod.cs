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
    public class ShippingMethod : IDynamicFieldsContainer
    {
        public string Area { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string Countries { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastModified { get; set; }
        public string Name { get; set; }
        public Guid Owner { get; set; }
        public Guid ShippingCarrierId { get; set; }
        public string ShippingLimitToDisplay { get; set; }
        public string ShippingMethodSettings { get; set; }
        public ShippingMethodType ShippingMethodType { get; set; }
        public string ShippingPrice { get; set; }
        public string ShippingPriceToDisplay { get; set; }
        public int SortOrder { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public Lstring Title { get; set; }
        public int Version { get; set; }
        public bool Visible { get; set; }

        public ShippingMethod() { }
    }
}
