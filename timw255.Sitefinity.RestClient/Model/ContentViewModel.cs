using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentViewModel : ContentViewModelBase
    {        
        [Obsolete("To get content, use ContentItemService GetContent method.")]
        public LstringSingleViewModel Content { get; set; }
        public DateTime? LastModified { get; set; }
        public string PageProviderName { get; set; }
        public int PagesCount { get; set; }
        public string PagesCountUIString { get; set; }
        public int PageTemplatesCount { get; set; }
        public override string Status { get; set; }

        public ContentViewModel() { }
    }
}
