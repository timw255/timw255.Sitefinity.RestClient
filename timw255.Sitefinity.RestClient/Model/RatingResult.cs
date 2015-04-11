using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class RatingResult
    {
        public decimal Average { get; set; }
        public string SubtitleMessage { get; set; }
        public uint VotesCount { get; set; }

        public RatingResult() { }
    }
}
