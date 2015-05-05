using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentItemContext<T> : RelatedDataItemContextBase<T>
    where T : IContent
    {
        private string itemType;
        public string[] AdditionalUrlNames { get; set; }
        public bool AdditionalUrlsRedirectToDefault { get; set; }
        public bool AllowMultipleUrls { get; set; }
        public string DefaultUrl { get; set; }
        public override T Item
        {
            get
            {
                return base.Item;
            }
            set
            {
                base.Item = value;
                this.itemType = value.GetType().FullName;
            }
        }
        public string ItemType
        {
            get
            {
                return this.itemType;
            }
            set
            {
                this.itemType = value;
            }
        }
        public WcfApprovalTrackingRecord LastApprovalTrackingRecord { get; set; }
        public WcfContentLifecycleStatus LifecycleStatus { get; set; }
        public List<WcfPipeSettings> PublicationSettings { get; set; }
        public WcfChange VersionInfo { get; set; }

        public ContentItemContext() { }
    }
}
