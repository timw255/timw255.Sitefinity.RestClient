using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DocumentLibraryItemViewModel : DocumentViewModel
    {
        public string DocumentsCount { get; set; }
        public bool IsFolder { get; set; }
        public string LibrariesCount { get; set; }

        public DocumentLibraryItemViewModel() { }
    }
}
