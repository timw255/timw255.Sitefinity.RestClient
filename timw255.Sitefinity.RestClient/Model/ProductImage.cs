using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductImage
    {
        public string Album { get; set; }
        public Guid AlbumId { get; set; }
        public Lstring AlternativeText { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public int Height { get; set; }
        public Guid Id { get; set; }
        public string ImageDimensions { get; set; }
        public int Ordinal { get; set; }
        public int ThumbnailHeight { get; set; }
        public string ThumbnailUrl { get; set; }
        public int ThumbnailWidth { get; set; }
        public string Title { get; set; }
        public string UploadedDate { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }

        public ProductImage() { }
    }
}
