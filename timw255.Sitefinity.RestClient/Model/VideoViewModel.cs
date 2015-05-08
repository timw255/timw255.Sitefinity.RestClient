using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class VideoViewModel : MediaContentViewModel
    {
        public string CategoryText { get; set; }
        public string Duration { get; set; }
        public int Height { get; set; }
        public string LibraryFullUrl { get; set; }
        public int SnapshotHeight { get; set; }
        public string SnapshotUrl { get; set; }
        public int SnapshotWidth { get; set; }
        public string TagsText { get; set; }
        public int Width { get; set; }

        public VideoViewModel() { }
    }
}
