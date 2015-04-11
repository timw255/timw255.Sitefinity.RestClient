using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ImageViewModel : MediaContentViewModel
    {
        public string AlternativeText { get; set; }
        public string CategoryText { get; set; }
        public int Height { get; set; }
        public override bool IsManageable { get; set; }
        public string LibraryFullUrl { get; set; }
        public string TagsText { get; set; }
        public string ThumbnailUrl { get; set; }
        public int Width { get; set; }

        public ImageViewModel() { }
    }
}
