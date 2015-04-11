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
    public class PaymentMethod : IDynamicFieldsContainer
    {
        [Obsolete("User Payment Processor settings going forward")]
        public string AuthNetSettings { get; set; }
        public string[] AvailableLanguages { get; set; }
        public Lstring Description { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public Guid Owner { get; set; }
        [Obsolete("User Payment Processor settings going forward")]
        public string PayFlowProSettings { get; set; }
        public PaymentMethodType PaymentMethodType { get; set; }
        public string PaymentMethodTypeString { get; set; }
        public Guid PaymentProcessorId { get; set; }
        public string PaymentProcessorSettings { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public Lstring Title { get; set; }
        public int Version { get; set; }
        public bool Visible { get; set; }

        public PaymentMethod() { }
    }
}
