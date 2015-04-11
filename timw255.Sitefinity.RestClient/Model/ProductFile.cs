using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductFile
    {
        public string Extension { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public Guid Id { get; set; }
        public int Ordinal { get; set; }
        public string Title { get; set; }
        public long TotalSize { get; set; }
        public string UploadedDate { get; set; }
        public string Url { get; set; }

        public ProductFile() { }
    }
}
