using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Image : MediaContent
    {
        public Album Album { get; set; }
        public LstringSingleViewModel AlternativeText { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Image() { }
    }
}
