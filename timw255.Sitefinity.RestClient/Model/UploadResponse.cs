using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [JsonObject]
    public class UploadResponse
    {
        public string ContentId { get; set; }
        public MediaContentViewModel ContentItem { get; set; }
        public string ContentUrl { get; set; }
        public string ErrorMessage { get; set; }
        public bool UploadResult { get; set; }

        public UploadResponse() { }
    }
}
