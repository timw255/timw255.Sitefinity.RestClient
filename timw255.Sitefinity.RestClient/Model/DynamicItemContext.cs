using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DynamicItemContext : RelatedDataItemContextBase<DynamicContent>
    {
        public bool HasLiveVersion { get; set; }
        public override DynamicContent Item
        {
            get
            {
                return base.Item;
            }
            set
            {
                base.Item = value;
                this.ItemType = value.GetType().FullName;
            }
        }
        public string ItemType { get; set; }
        public WcfChange VersionInfo { get; set; }

        public DynamicItemContext() { }
    }
}
