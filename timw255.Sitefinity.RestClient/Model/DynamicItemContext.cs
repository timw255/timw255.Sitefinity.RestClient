using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Versioning.Web.Services;
using Telerik.Sitefinity.Web.Services;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class DynamicItemContext : RelatedDataItemContextBase<DynamicContent>
    {
        [DataMember]
        public bool HasLiveVersion { get; set; }

        [DataMember]
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

        [DataMember]
        public string ItemType { get; set; }

        [DataMember]
        public WcfChange VersionInfo { get; set; }

        public DynamicItemContext() { }
    }
}
