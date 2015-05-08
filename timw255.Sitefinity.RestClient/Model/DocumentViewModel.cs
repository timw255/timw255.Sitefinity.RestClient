using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DocumentViewModel : MediaContentViewModel
    {
        public string CategoryText { get; set; }
        public string LibraryFullUrl { get; set; }
        public string TagsText { get; set; }

        public DocumentViewModel() { }
    }
}
