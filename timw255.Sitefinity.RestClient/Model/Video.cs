using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Video : MediaContent
    {
        public int Height { get; set; }
        public VideoLibrary Library { get; set; }
        public int Width { get; set; }

        public Video() { }
    }
}
