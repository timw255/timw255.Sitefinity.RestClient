using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class InventoryReportViewModel
    {
        public Guid Id { get; set; }
        public int Inventory { get; set; }
        public string InventoryAmountMessage { get; set; }
        public string InventoryStatus { get; set; }
        public string InventoryStatusMessage { get; set; }
        public string Price { get; set; }
        public string ProductTypeTitle { get; set; }
        public string SiteVisibility { get; set; }
        public string SiteVisibilityMessage { get; set; }
        public string Sku { get; set; }
        public string Title { get; set; }

        public InventoryReportViewModel() { }
    }
}
