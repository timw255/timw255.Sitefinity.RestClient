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
    public class Discount : IDynamicFieldsContainer
    {
        public ApplyDiscountFor ApplyFor { get; set; }
        public string ApplyForJson { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string CouponCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountAmountDisplay { get; set; }
        public string DiscountAmountJson { get; set; }
        public DiscountAmountType DiscountAmountType { get; set; }
        public DiscountType DiscountType { get; set; }
        public int DiscountUsed { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsCouponCodeRequired { get; set; }
        public DateTime LastModified { get; set; }
        public decimal? MaximumSubtotal { get; set; }
        public decimal MinimumSubtotal { get; set; }
        public Guid Owner { get; set; }
        public DateTime StartDate { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public Lstring Title { get; set; }
        public int Usage { get; set; }
        public string UsageString { get; set; }
        public int Version { get; set; }
        public bool Visible { get; set; }

        public Discount() { }
    }
}
