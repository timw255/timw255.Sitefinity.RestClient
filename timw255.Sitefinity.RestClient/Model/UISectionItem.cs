using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class UISectionItem
    {
        public bool CanDelete { get; set; }
        public bool CanOrder { get; set; }
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public string ElementCssClass { get; set; }
        public bool HasChildren { get; set; }
        public bool IsCollection { get; set; }
        public bool IsNew { get; set; }
        public string ItemTypeName { get; set; }
        public string Key { get; set; }
        public bool NeedsEditor { get; set; }
        public string Parent { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }

        public UISectionItem() { }
    }
}
