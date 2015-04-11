using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class VideoLibraryItemViewModel : VideoViewModel
    {
        public bool IsFolder { get; set; }
        public string LibrariesCount { get; set; }
        public string VideosCount { get; set; }

        public VideoLibraryItemViewModel() { }
    }
}
