using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentItem : ContentBase
    {
        public string Author { get; set; }
        public string CategoryText { get; set; }
        public Lstring Content { get; set; }
        public string Name { get; set; }
        public string TagsText { get; set; }

        public ContentItem() { }
    }
}
