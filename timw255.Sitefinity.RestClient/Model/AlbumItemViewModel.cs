using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class AlbumItemViewModel : ImageViewModel
    {
        public string ImagesCount { get; set; }
        public bool IsFolder { get; set; }
        public string LibrariesCount { get; set; }

        public AlbumItemViewModel() { }
    }
}
