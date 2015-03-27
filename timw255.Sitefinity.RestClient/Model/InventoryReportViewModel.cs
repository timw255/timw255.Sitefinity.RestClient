using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class InventoryReportViewModel
    {
        public Guid Id { get; set; }

        [DataMember]
        public int Inventory { get; set; }

        [DataMember]
        public string InventoryAmountMessage { get; set; }

        [DataMember]
        public string InventoryStatus { get; set; }

        [DataMember]
        public string InventoryStatusMessage { get; set; }

        [DataMember]
        public string Price { get; set; }

        [DataMember]
        public string ProductTypeTitle { get; set; }

        [DataMember]
        public string SiteVisibility { get; set; }

        [DataMember]
        public string SiteVisibilityMessage { get; set; }

        [DataMember]
        public string Sku { get; set; }

        [DataMember]
        public string Title { get; set; }

        public InventoryReportViewModel() { }
    }
}
